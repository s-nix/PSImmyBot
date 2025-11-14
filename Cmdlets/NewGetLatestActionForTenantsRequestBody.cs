using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetLatestActionForTenantsRequestBody")]
public class NewGetLatestActionForTenantsRequestBody : Cmdlet {
    [Parameter(Mandatory = false)] public DateTimeOffset? DateUtc { get; set; }
    [Parameter(Mandatory = false)] public string? MaintenanceIdentifier { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceType MaintenanceType { get; set; }
    [Parameter(Mandatory = false)] public ICollection<int>? TenantIds { get; set; }

    protected override void ProcessRecord() {
        GetLatestActionForTenantsRequestBody outputObject = new(DateUtc, MaintenanceIdentifier, MaintenanceType, TenantIds);
        WriteObject(outputObject);
    }
}
