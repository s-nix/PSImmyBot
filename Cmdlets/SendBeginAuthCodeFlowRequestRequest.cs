using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "BeginAuthCodeFlowRequestRequest")]
public class SendBeginAuthCodeFlowRequestRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required BeginAuthCodeFlowRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/oauth/begin-auth-code-flow?";

        BeginAuthCodeFlowResponse response = ImmyBotApiService.Post<BeginAuthCodeFlowRequest, BeginAuthCodeFlowResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
