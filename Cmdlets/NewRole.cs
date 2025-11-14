using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "Role")]
public class NewRole : Cmdlet {
    [Parameter(Mandatory = false)] public string? ConcurrencyStamp { get; set; }
    [Parameter(Mandatory = false)] public int? CreatedBy { get; set; }
    [Parameter(Mandatory = true)] public required User CreatedByUser { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDate { get; set; }
    [Parameter(Mandatory = false)] public ICollection<AuditPropertyChange>? CustomAuditProperties { get; set; }
    [Parameter(Mandatory = false)] public string? Description { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = false)] public string? NormalizedName { get; set; }
    [Parameter(Mandatory = false)] public ICollection<RoleClaim>? RoleClaims { get; set; }
    [Parameter(Mandatory = true)] public required RoleType RoleType { get; set; }
    [Parameter(Mandatory = true)] public required int RoleTypeId { get; set; }
    [Parameter(Mandatory = true)] public required TenantRestrictionMode TenantRestrictionMode { get; set; }
    [Parameter(Mandatory = false)] public int? UpdatedBy { get; set; }
    [Parameter(Mandatory = true)] public required User UpdatedByUser { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDate { get; set; }
    [Parameter(Mandatory = false)] public ICollection<UserRole>? UserRoles { get; set; }

    protected override void ProcessRecord() {
        Role outputObject = new(ConcurrencyStamp, CreatedBy, CreatedByUser, CreatedDate, CustomAuditProperties, Description, Id, Name, NormalizedName, RoleClaims, RoleType, RoleTypeId, TenantRestrictionMode, UpdatedBy, UpdatedByUser, UpdatedDate, UserRoles);
        WriteObject(outputObject);
    }
}
