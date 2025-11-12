using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "FailAuthCodeFlowRequestRequest")]
public class SendFailAuthCodeFlowRequestRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required FailAuthCodeFlowRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/oauth/fail-auth-code-flow?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
    }

}
