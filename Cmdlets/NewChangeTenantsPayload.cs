using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ChangeTenantsPayload")]
public class NewChangeTenantsPayload : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<int>? ComputersToMove { get; set; }
    [Parameter(Mandatory = true)] public required int TargetTenantId { get; set; }

    protected override void ProcessRecord() {
        ChangeTenantsPayload outputObject = new(ComputersToMove, TargetTenantId);
        WriteObject(outputObject);
    }
}
