using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ApplicationLockCallerInfo")]
public class NewApplicationLockCallerInfo : Cmdlet {
    [Parameter(Mandatory = true)] public required Guid Id { get; set; }
    [Parameter(Mandatory = true)] public required bool IsLockHolder { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset Since { get; set; }

    protected override void ProcessRecord() {
        ApplicationLockCallerInfo outputObject = new(Id, IsLockHolder, Name, Since);
        WriteObject(outputObject);
    }
}
