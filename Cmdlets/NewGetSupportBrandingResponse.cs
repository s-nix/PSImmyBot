using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetSupportBrandingResponse")]
public class NewGetSupportBrandingResponse : Cmdlet {
    [Parameter(Mandatory = false)] public string? DescriptionAlertMessage { get; set; }
    [Parameter(Mandatory = false)] public string? DescriptionPlaceholderText { get; set; }
    [Parameter(Mandatory = false)] public string? FooterMessage { get; set; }
    [Parameter(Mandatory = false)] public string? HeaderAlertMessage { get; set; }
    [Parameter(Mandatory = true)] public required Guid ProviderId { get; set; }
    [Parameter(Mandatory = false)] public string? SessionSupportButtonTitle { get; set; }
    [Parameter(Mandatory = true)] public required bool ShowConfirmationCheckbox { get; set; }
    [Parameter(Mandatory = true)] public required bool ShowSessionSupportConfirmCheckbox { get; set; }
    [Parameter(Mandatory = false)] public string? SupportSidebarTitle { get; set; }

    protected override void ProcessRecord() {
        GetSupportBrandingResponse outputObject = new(DescriptionAlertMessage, DescriptionPlaceholderText, FooterMessage, HeaderAlertMessage, ProviderId, SessionSupportButtonTitle, ShowConfirmationCheckbox, ShowSessionSupportConfirmCheckbox, SupportSidebarTitle);
        WriteObject(outputObject);
    }
}
