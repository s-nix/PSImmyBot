using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "MaintenanceSession")]
public class GetMaintenanceSession : Cmdlet {
    [Parameter(Mandatory = true)]
    public int SessionId { get; set; }

    [Parameter(Mandatory = false)]
    public bool? IncludeActions { get; set; }

    [Parameter(Mandatory = false)]
    public bool? IncludeStages { get; set; }

    [Parameter(Mandatory = false)]
    public bool? IncludeActionActivities { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/maintenance-sessions/{SessionId}?";
        endpoint += Globals.ConvertToQueryParameters(IncludeActions, "includeActions");
        endpoint += Globals.ConvertToQueryParameters(IncludeStages, "includeStages");
        endpoint += Globals.ConvertToQueryParameters(IncludeActionActivities, "includeActionActivities");

        GetMaintenanceSessionResponse response = ImmyBotApiService.Get<GetMaintenanceSessionResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
