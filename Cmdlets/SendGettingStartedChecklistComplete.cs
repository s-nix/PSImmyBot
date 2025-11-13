using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "GettingStartedChecklistComplete")]
public class SendGettingStartedChecklistComplete : Cmdlet {


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/getting-started/checklist/complete?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
