using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "MaintenanceActionsForMaintenanceItem")]
public class GetMaintenanceActionsForMaintenanceItem : Cmdlet
{
    [Parameter(Mandatory = true)]
    public MaintenanceType MaintenanceType { get; set; }

    [Parameter(Mandatory = true)]
    public required string MaintenanceIdentifier { get; set; }


    protected override void ProcessRecord()
    {
        string endpoint = "/api/v1/maintenance-actions/maintenance-item?";
        endpoint += Globals.ConvertToQueryParameters(MaintenanceType, "maintenanceType");
        endpoint += Globals.ConvertToQueryParameters(MaintenanceIdentifier, "maintenanceIdentifier");

        List<GetMaintenanceActionResponse> response = ImmyBotApiService.Get<List<GetMaintenanceActionResponse>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
