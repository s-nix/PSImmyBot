using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ChocoPackageVersion")]
public class NewChocoPackageVersion : Cmdlet {
    [Parameter(Mandatory = false)] public string? Id { get; set; }
    [Parameter(Mandatory = true)] public required NuGetVersion SemanticVersion { get; set; }
    [Parameter(Mandatory = false)] public string? Title { get; set; }
    [Parameter(Mandatory = false)] public string? Version { get; set; }

    protected override void ProcessRecord() {
        ChocoPackageVersion outputObject = new(Id, SemanticVersion, Title, Version);
        WriteObject(outputObject);
    }
}
