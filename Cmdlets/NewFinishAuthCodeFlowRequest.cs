using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "FinishAuthCodeFlowRequest")]
public class NewFinishAuthCodeFlowRequest : Cmdlet {
    [Parameter(Mandatory = false)] public string? AuthCode { get; set; }
    [Parameter(Mandatory = true)] public required Guid OauthHookId { get; set; }
    [Parameter(Mandatory = false)] public Uri? RedirectUriUsedInAuthLeg { get; set; }

    protected override void ProcessRecord() {
        FinishAuthCodeFlowRequest outputObject = new(AuthCode, OauthHookId, RedirectUriUsedInAuthLeg);
        WriteObject(outputObject);
    }
}
