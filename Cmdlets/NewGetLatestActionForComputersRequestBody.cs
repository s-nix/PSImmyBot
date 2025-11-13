using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetLatestActionForComputersRequestBody")]
public class NewGetLatestActionForComputersRequestBody : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<int>? ComputerIds { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? DateUtc { get; set; }
    [Parameter(Mandatory = false)] public string? MaintenanceIdentifier { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceType MaintenanceType { get; set; }

    protected override void ProcessRecord() {
        GetLatestActionForComputersRequestBody outputObject = new(ComputerIds, DateUtc, MaintenanceIdentifier, MaintenanceType);
        WriteObject(outputObject);
    }
}
