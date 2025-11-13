using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "CreateLicenseRequestBody")]
public class NewCreateLicenseRequestBody : Cmdlet {
    [Parameter(Mandatory = false)] public string? LicenseValue { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = true)] public required bool RestrictToMajorVersion { get; set; }
    [Parameter(Mandatory = true)] public required SemanticVersion SemanticVersion { get; set; }
    [Parameter(Mandatory = false)] public string? SoftwareIdentifier { get; set; }
    [Parameter(Mandatory = false)] public string? SoftwareName { get; set; }
    [Parameter(Mandatory = true)] public required SoftwareType SoftwareType { get; set; }
    [Parameter(Mandatory = false)] public int? TenantId { get; set; }

    protected override void ProcessRecord() {
        CreateLicenseRequestBody outputObject = new(LicenseValue, Name, RestrictToMajorVersion, SemanticVersion, SoftwareIdentifier, SoftwareName, SoftwareType, TenantId);
        WriteObject(outputObject);
    }
}
