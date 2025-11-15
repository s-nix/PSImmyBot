using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;

namespace PSImmyBot.Tests;

public class ModuleMetadataTests : IClassFixture<CmdletTestFixture>
{
    private readonly CmdletTestFixture _fixture;

    public ModuleMetadataTests(CmdletTestFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public void Module_exports_all_cmdlet_types()
    {
        HashSet<string> expected = _fixture.CommandNamesByType.Values.ToHashSet(StringComparer.OrdinalIgnoreCase);
        Assert.NotEmpty(expected);

        using PowerShell powershell = PowerShell.Create();
        powershell.Runspace = _fixture.Runspace;
        powershell.AddCommand("Get-Command").AddParameter("Module", _fixture.ModuleName);
        Collection<PSObject> results = powershell.Invoke();
        if (powershell.HadErrors)
        {
            string errors = string.Join(Environment.NewLine, powershell.Streams.Error.Select(e => e.ToString()));
            throw new InvalidOperationException($"Get-Command failed: {errors}");
        }

        HashSet<string> actual = results
            .Select(psObject => (psObject.BaseObject as CommandInfo)!)
            .Select(cmd => cmd.Name)
            .ToHashSet(StringComparer.OrdinalIgnoreCase);

        Assert.Equal(expected, actual);
    }
}
