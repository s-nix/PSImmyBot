using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "GettingStartedChecklistResetRequest")]
public class SendGettingStartedChecklistResetRequest : Cmdlet {


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/getting-started/checklist/reset?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
