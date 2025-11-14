using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "Oauth2AccessToken")]
public class NewOauth2AccessToken : Cmdlet {
    [Parameter(Mandatory = true)] public required DateTimeOffset AccessTokenExpiresAtUtc { get; set; }
    [Parameter(Mandatory = false)] public string? AccessTokenId { get; set; }
    [Parameter(Mandatory = true)] public required bool AllowSilentRefresh { get; set; }
    [Parameter(Mandatory = true)] public required OauthConsentData ConsentData { get; set; }
    [Parameter(Mandatory = false)] public int? CreatedBy { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDate { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public string? IdentityTokenId { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? RefreshTokenExpiresAtUtc { get; set; }
    [Parameter(Mandatory = false)] public string? RefreshTokenId { get; set; }
    [Parameter(Mandatory = false)] public string? TenantPrincipalId { get; set; }
    [Parameter(Mandatory = false)] public string? TokenType { get; set; }
    [Parameter(Mandatory = false)] public int? UpdatedBy { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDate { get; set; }

    protected override void ProcessRecord() {
        Oauth2AccessToken outputObject = new(AccessTokenExpiresAtUtc, AccessTokenId, AllowSilentRefresh, ConsentData, CreatedBy, CreatedDate, Id, IdentityTokenId, RefreshTokenExpiresAtUtc, RefreshTokenId, TenantPrincipalId, TokenType, UpdatedBy, UpdatedDate);
        WriteObject(outputObject);
    }
}
