using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "MaintenanceEmailsJobsPostpone")]
public class GetMaintenanceEmailsJobsPostpone : Cmdlet {
    [Parameter(Mandatory = true)]
    public required string EmailGuid { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/maintenance-emails/{EmailGuid}/jobs/postpone?";

        string response = ImmyBotApiService.Get<string>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
