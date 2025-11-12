using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "GettingStartedChecklistCompleteRequest")]
public class SendGettingStartedChecklistCompleteRequest : Cmdlet {


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/getting-started/checklist/complete?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
