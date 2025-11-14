using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "UserRole")]
public class NewUserRole : Cmdlet {
    [Parameter(Mandatory = false)] public string? AuditObjectName { get; set; }
    [Parameter(Mandatory = false)] public int? CreatedBy { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDate { get; set; }
    [Parameter(Mandatory = true)] public required Role Role { get; set; }
    [Parameter(Mandatory = true)] public required int RoleId { get; set; }
    [Parameter(Mandatory = false)] public int? UpdatedBy { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDate { get; set; }
    [Parameter(Mandatory = true)] public required User User { get; set; }
    [Parameter(Mandatory = true)] public required int UserId { get; set; }

    protected override void ProcessRecord() {
        UserRole outputObject = new(AuditObjectName, CreatedBy, CreatedDate, Role, RoleId, UpdatedBy, UpdatedDate, User, UserId);
        WriteObject(outputObject);
    }
}
