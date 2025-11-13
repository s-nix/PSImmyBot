using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "IPermissionMetadata")]
public class NewIPermissionMetadata : Cmdlet {
    [Parameter(Mandatory = false)] public string? AllowClaim { get; set; }
    [Parameter(Mandatory = true)] public required PermissionCategory Category { get; set; }
    [Parameter(Mandatory = false)] public string? Claim { get; set; }
    [Parameter(Mandatory = false)] public string? DenyClaim { get; set; }
    [Parameter(Mandatory = false)] public ICollection<IPermissionMetadata>? Dependencies { get; set; }
    [Parameter(Mandatory = false)] public string? Description { get; set; }
    [Parameter(Mandatory = false)] public string? DisplayName { get; set; }
    [Parameter(Mandatory = true)] public required bool HasGreatPower { get; set; }
    [Parameter(Mandatory = false)] public string? Id { get; set; }
    [Parameter(Mandatory = true)] public required bool IsMspOnly { get; set; }
    [Parameter(Mandatory = true)] public required bool IsSystemManaged { get; set; }
    [Parameter(Mandatory = false)] public string? PermissionName { get; set; }
    [Parameter(Mandatory = false)] public string? ResourceClaimType { get; set; }
    [Parameter(Mandatory = true)] public required int SortOrder { get; set; }
    [Parameter(Mandatory = true)] public required ISubjectMetadata Subject { get; set; }
    [Parameter(Mandatory = false)] public string? SubjectClaimType { get; set; }
    [Parameter(Mandatory = false)] public string? TenantClaimType { get; set; }

    protected override void ProcessRecord() {
        IPermissionMetadata outputObject = new(AllowClaim, Category, Claim, DenyClaim, Dependencies, Description, DisplayName, HasGreatPower, Id, IsMspOnly, IsSystemManaged, PermissionName, ResourceClaimType, SortOrder, Subject, SubjectClaimType, TenantClaimType);
        WriteObject(outputObject);
    }
}
