using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "MaintenanceEmailsJobsRebootnow")]
public class GetMaintenanceEmailsJobsRebootnow : Cmdlet {
    [Parameter(Mandatory = true)]
    public required string EmailGuid { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/maintenance-emails/{EmailGuid}/jobs/rebootnow?";

        string response = ImmyBotApiService.Get<string>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
