using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "CreateBrandingRequestBody")]
public class NewCreateBrandingRequestBody : Cmdlet {
    [Parameter(Mandatory = false)] public string? BackgroundColor { get; set; }
    [Parameter(Mandatory = false)] public string? Description { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? EndDate { get; set; }
    [Parameter(Mandatory = false)] public string? ForegroundColor { get; set; }
    [Parameter(Mandatory = false)] public string? FromAddress { get; set; }
    [Parameter(Mandatory = false)] public bool? IgnoreYear { get; set; }
    [Parameter(Mandatory = false)] public string? LogoAltText { get; set; }
    [Parameter(Mandatory = false)] public string? LogoUri { get; set; }
    [Parameter(Mandatory = false)] public string? MascotImgUri { get; set; }
    [Parameter(Mandatory = false)] public string? MascotName { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? StartDate { get; set; }
    [Parameter(Mandatory = false)] public string? TableHeaderColor { get; set; }
    [Parameter(Mandatory = false)] public string? TableHeaderTextColor { get; set; }
    [Parameter(Mandatory = false)] public int? TenantId { get; set; }
    [Parameter(Mandatory = false)] public string? TextColor { get; set; }
    [Parameter(Mandatory = false)] public string? TimeFormat { get; set; }

    protected override void ProcessRecord() {
        CreateBrandingRequestBody outputObject = new(BackgroundColor, Description, EndDate, ForegroundColor, FromAddress, IgnoreYear, LogoAltText, LogoUri, MascotImgUri, MascotName, StartDate, TableHeaderColor, TableHeaderTextColor, TenantId, TextColor, TimeFormat);
        WriteObject(outputObject);
    }
}
