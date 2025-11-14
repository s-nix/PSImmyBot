using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetBrandingResponse")]
public class NewGetBrandingResponse : Cmdlet {
    [Parameter(Mandatory = false)] public string? BackgroundColor { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDateUtc { get; set; }
    [Parameter(Mandatory = false)] public string? Description { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? EndDate { get; set; }
    [Parameter(Mandatory = false)] public string? ForegroundColor { get; set; }
    [Parameter(Mandatory = false)] public string? FromAddress { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public bool? IgnoreYear { get; set; }
    [Parameter(Mandatory = false)] public string? LogoAltText { get; set; }
    [Parameter(Mandatory = false)] public string? LogoUri { get; set; }
    [Parameter(Mandatory = false)] public string? MascotImgUri { get; set; }
    [Parameter(Mandatory = false)] public string? MascotName { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? StartDate { get; set; }
    [Parameter(Mandatory = false)] public string? TableHeaderColor { get; set; }
    [Parameter(Mandatory = false)] public string? TableHeaderTextColor { get; set; }
    [Parameter(Mandatory = false)] public int? TenantId { get; set; }
    [Parameter(Mandatory = false)] public string? TenantName { get; set; }
    [Parameter(Mandatory = false)] public string? TextColor { get; set; }
    [Parameter(Mandatory = false)] public string? TimeFormat { get; set; }
    [Parameter(Mandatory = false)] public string? UpdatedBy { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDateUtc { get; set; }

    protected override void ProcessRecord() {
        GetBrandingResponse outputObject = new(BackgroundColor, CreatedDateUtc, Description, EndDate, ForegroundColor, FromAddress, Id, IgnoreYear, LogoAltText, LogoUri, MascotImgUri, MascotName, StartDate, TableHeaderColor, TableHeaderTextColor, TenantId, TenantName, TextColor, TimeFormat, UpdatedBy, UpdatedDateUtc);
        WriteObject(outputObject);
    }
}
