using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetRoleResponse")]
public class NewGetRoleResponse : Cmdlet {
    [Parameter(Mandatory = false)] public DateTimeOffset? CreatedDate { get; set; }
    [Parameter(Mandatory = false)] public string? Description { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = false)] public ICollection<GetRoleClaimResponse>? RoleClaims { get; set; }
    [Parameter(Mandatory = true)] public required int RoleTypeId { get; set; }
    [Parameter(Mandatory = false)] public string? RoleTypeName { get; set; }
    [Parameter(Mandatory = false)] public string? UpdatedBy { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? UpdatedDate { get; set; }
    [Parameter(Mandatory = true)] public required int UserCount { get; set; }

    protected override void ProcessRecord() {
        GetRoleResponse outputObject = new(CreatedDate, Description, Id, Name, RoleClaims, RoleTypeId, RoleTypeName, UpdatedBy, UpdatedDate, UserCount);
        WriteObject(outputObject);
    }
}
