using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "MaintenanceTasksGlobalParamBlockFromParametersRequest")]
public class SendMaintenanceTasksGlobalParamBlockFromParametersRequest : Cmdlet {
    [Parameter(Mandatory = true)]
    public int Id { get; set; }



    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/maintenance-tasks/global/{Id}/param-block-from-parameters?";

        string response = ImmyBotApiService.Post<string>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
