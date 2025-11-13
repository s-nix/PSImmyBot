using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "RoleClaim")]
public class NewRoleClaim : Cmdlet {
    [Parameter(Mandatory = false)] public string? AuditObjectName { get; set; }
    [Parameter(Mandatory = false)] public string? ClaimType { get; set; }
    [Parameter(Mandatory = false)] public string? ClaimValue { get; set; }
    [Parameter(Mandatory = false)] public int? CreatedBy { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDate { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = true)] public required Role Role { get; set; }
    [Parameter(Mandatory = true)] public required int RoleId { get; set; }
    [Parameter(Mandatory = false)] public int? UpdatedBy { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDate { get; set; }

    protected override void ProcessRecord() {
        RoleClaim outputObject = new(AuditObjectName, ClaimType, ClaimValue, CreatedBy, CreatedDate, Id, Role, RoleId, UpdatedBy, UpdatedDate);
        WriteObject(outputObject);
    }
}
