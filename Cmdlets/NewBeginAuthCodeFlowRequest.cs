using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "BeginAuthCodeFlowRequest")]
public class NewBeginAuthCodeFlowRequest : Cmdlet {
    [Parameter(Mandatory = true)] public required bool AllowSilentRefresh { get; set; }
    [Parameter(Mandatory = true)] public required OauthConsentData OauthConsentData { get; set; }

    protected override void ProcessRecord() {
        BeginAuthCodeFlowRequest outputObject = new(AllowSilentRefresh, OauthConsentData);
        WriteObject(outputObject);
    }
}
