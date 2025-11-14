using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetSimplePersonResponse")]
public class NewGetSimplePersonResponse : Cmdlet {
    [Parameter(Mandatory = false)] public string? AzurePrincipalId { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDateUtc { get; set; }
    [Parameter(Mandatory = false)] public string? EmailAddress { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? ExpirationDateUtc { get; set; }
    [Parameter(Mandatory = false)] public string? FirstName { get; set; }
    [Parameter(Mandatory = false)] public string? FullName { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public string? LastName { get; set; }
    [Parameter(Mandatory = false)] public string? OnPremisesSecurityIdentifier { get; set; }
    [Parameter(Mandatory = false)] public ICollection<int>? PersonTagIds { get; set; }
    [Parameter(Mandatory = false)] public ICollection<int>? RoleIds { get; set; }
    [Parameter(Mandatory = true)] public required int TenantId { get; set; }
    [Parameter(Mandatory = false)] public string? TenantName { get; set; }
    [Parameter(Mandatory = false)] public string? UpdatedBy { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDateUtc { get; set; }
    [Parameter(Mandatory = false)] public int? UserId { get; set; }

    protected override void ProcessRecord() {
        GetSimplePersonResponse outputObject = new(AzurePrincipalId, CreatedDateUtc, EmailAddress, ExpirationDateUtc, FirstName, FullName, Id, LastName, OnPremisesSecurityIdentifier, PersonTagIds, RoleIds, TenantId, TenantName, UpdatedBy, UpdatedDateUtc, UserId);
        WriteObject(outputObject);
    }
}
