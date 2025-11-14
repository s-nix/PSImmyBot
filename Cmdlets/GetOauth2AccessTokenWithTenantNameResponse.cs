using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "Oauth2AccessTokenWithTenantNameResponse")]
public class GetOauth2AccessTokenWithTenantNameResponse : Cmdlet {
    [Parameter(Mandatory = true)]
    public int Id { get; set; }

    [Parameter(Mandatory = true)]
    public required string AccessTokenId { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/oauth/oauth-access-tokens/{Id}/{AccessTokenId}?";

        Oauth2AccessTokenWithTenantNameResponse response = ImmyBotApiService.Get<Oauth2AccessTokenWithTenantNameResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
