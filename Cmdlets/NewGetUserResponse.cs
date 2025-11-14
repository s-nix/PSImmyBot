using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetUserResponse")]
public class NewGetUserResponse : Cmdlet {
    [Parameter(Mandatory = false)] public string? AzurePrincipalId { get; set; }
    [Parameter(Mandatory = true)] public required bool CanManageCrossTenantDeployments { get; set; }
    [Parameter(Mandatory = false)] public string? CompanyName { get; set; }
    [Parameter(Mandatory = false)] public string? Email { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? ExpirationDateUtc { get; set; }
    [Parameter(Mandatory = true)] public required bool HasManagementAccess { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = true)] public required bool IsAdmin { get; set; }
    [Parameter(Mandatory = true)] public required bool IsExpired { get; set; }
    [Parameter(Mandatory = true)] public required bool IsMsp { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = false)] public int? PersonId { get; set; }
    [Parameter(Mandatory = false)] public ICollection<string>? Roles { get; set; }
    [Parameter(Mandatory = true)] public required int TenantId { get; set; }
    [Parameter(Mandatory = false)] public string? Type { get; set; }

    protected override void ProcessRecord() {
        GetUserResponse outputObject = new(AzurePrincipalId, CanManageCrossTenantDeployments, CompanyName, Email, ExpirationDateUtc, HasManagementAccess, Id, IsAdmin, IsExpired, IsMsp, Name, PersonId, Roles, TenantId, Type);
        WriteObject(outputObject);
    }
}
