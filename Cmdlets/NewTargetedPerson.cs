using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "TargetedPerson")]
public class NewTargetedPerson : Cmdlet {
    [Parameter(Mandatory = false)] public string? Email { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = true)] public required int PersonId { get; set; }
    [Parameter(Mandatory = true)] public required int TenantId { get; set; }

    protected override void ProcessRecord() {
        TargetedPerson outputObject = new(Email, Name, PersonId, TenantId);
        WriteObject(outputObject);
    }
}
