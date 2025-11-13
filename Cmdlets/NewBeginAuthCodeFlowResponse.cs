using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "BeginAuthCodeFlowResponse")]
public class NewBeginAuthCodeFlowResponse : Cmdlet {
    [Parameter(Mandatory = true)] public required Guid OauthHookId { get; set; }

    protected override void ProcessRecord() {
        BeginAuthCodeFlowResponse outputObject = new(OauthHookId);
        WriteObject(outputObject);
    }
}
