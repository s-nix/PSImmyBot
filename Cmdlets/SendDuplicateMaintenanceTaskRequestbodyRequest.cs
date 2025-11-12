using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "DuplicateMaintenanceTaskRequestbodyRequest")]
public class SendDuplicateMaintenanceTaskRequestbodyRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required DuplicateMaintenanceTaskRequestbody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/maintenance-tasks/duplicate?";

        GetLocalMaintenanceTaskResponse response = ImmyBotApiService.Post<DuplicateMaintenanceTaskRequestbody, GetLocalMaintenanceTaskResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
