using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "FailAuthCodeFlowRequest")]
public class NewFailAuthCodeFlowRequest : Cmdlet {
    [Parameter(Mandatory = true)] public required Oauth2AuthCodeErrorResponse OauthErrorResponse { get; set; }
    [Parameter(Mandatory = true)] public required Guid OauthHookId { get; set; }

    protected override void ProcessRecord() {
        FailAuthCodeFlowRequest outputObject = new(OauthErrorResponse, OauthHookId);
        WriteObject(outputObject);
    }
}
