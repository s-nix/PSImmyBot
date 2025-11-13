using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "FinishAuthCodeFlowRequestRequest")]
public class SendFinishAuthCodeFlowRequestRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required FinishAuthCodeFlowRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/oauth/finish-auth-code-flow?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
    }

}
