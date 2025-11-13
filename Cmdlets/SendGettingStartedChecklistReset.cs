using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "GettingStartedChecklistReset")]
public class SendGettingStartedChecklistReset : Cmdlet {


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/getting-started/checklist/reset?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
