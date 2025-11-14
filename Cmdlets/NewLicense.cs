using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "License")]
public class NewLicense : Cmdlet {
    [Parameter(Mandatory = false)] public int? CreatedBy { get; set; }
    [Parameter(Mandatory = true)] public required User CreatedByUser { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDate { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public string? LicenseValue { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = true)] public required Tenant OwnerTenant { get; set; }
    [Parameter(Mandatory = true)] public required bool RestrictToMajorVersion { get; set; }
    [Parameter(Mandatory = true)] public required SemanticVersion SemanticVersion { get; set; }
    [Parameter(Mandatory = false)] public string? SoftwareIdentifier { get; set; }
    [Parameter(Mandatory = false)] public string? SoftwareName { get; set; }
    [Parameter(Mandatory = true)] public required SoftwareType SoftwareType { get; set; }
    [Parameter(Mandatory = false)] public ICollection<TargetAssignment>? TargetAssignments { get; set; }
    [Parameter(Mandatory = false)] public int? TenantId { get; set; }
    [Parameter(Mandatory = false)] public int? UpdatedBy { get; set; }
    [Parameter(Mandatory = true)] public required User UpdatedByUser { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDate { get; set; }

    protected override void ProcessRecord() {
        License outputObject = new(CreatedBy, CreatedByUser, CreatedDate, Id, LicenseValue, Name, OwnerTenant, RestrictToMajorVersion, SemanticVersion, SoftwareIdentifier, SoftwareName, SoftwareType, TargetAssignments, TenantId, UpdatedBy, UpdatedByUser, UpdatedDate);
        WriteObject(outputObject);
    }
}
