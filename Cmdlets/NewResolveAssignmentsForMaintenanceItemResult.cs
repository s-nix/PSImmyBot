using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ResolveAssignmentsForMaintenanceItemResult")]
public class NewResolveAssignmentsForMaintenanceItemResult : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<ComputerDto>? Computers { get; set; }
    [Parameter(Mandatory = false)] public ICollection<ResolveAssignmentsForMaintenanceItemResultItem>? Items { get; set; }

    protected override void ProcessRecord() {
        ResolveAssignmentsForMaintenanceItemResult outputObject = new(Computers, Items);
        WriteObject(outputObject);
    }
}
