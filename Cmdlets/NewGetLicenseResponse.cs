using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetLicenseResponse")]
public class NewGetLicenseResponse : Cmdlet {
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDate { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public string? LicenseValue { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = true)] public required bool RestrictToMajorVersion { get; set; }
    [Parameter(Mandatory = true)] public required SemanticVersion SemanticVersion { get; set; }
    [Parameter(Mandatory = false)] public string? SoftwareIdentifier { get; set; }
    [Parameter(Mandatory = false)] public string? SoftwareName { get; set; }
    [Parameter(Mandatory = true)] public required SoftwareType SoftwareType { get; set; }
    [Parameter(Mandatory = false)] public int? TenantId { get; set; }
    [Parameter(Mandatory = false)] public string? TenantName { get; set; }
    [Parameter(Mandatory = false)] public string? UpdatedBy { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDate { get; set; }

    protected override void ProcessRecord() {
        GetLicenseResponse outputObject = new(CreatedDate, Id, LicenseValue, Name, RestrictToMajorVersion, SemanticVersion, SoftwareIdentifier, SoftwareName, SoftwareType, TenantId, TenantName, UpdatedBy, UpdatedDate);
        WriteObject(outputObject);
    }
}
