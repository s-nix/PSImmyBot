using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "SendTestBrandingEmailRequest")]
public class NewSendTestBrandingEmailRequest : Cmdlet {
    [Parameter(Mandatory = true)] public required CreateBrandingRequestBody Branding { get; set; }
    [Parameter(Mandatory = false)] public string? To { get; set; }

    protected override void ProcessRecord() {
        SendTestBrandingEmailRequest outputObject = new(Branding, To);
        WriteObject(outputObject);
    }
}
