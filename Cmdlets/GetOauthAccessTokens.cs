using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "OauthAccessTokens")]
public class GetOauthAccessTokens : Cmdlet
{
    protected override void ProcessRecord()
    {
        string endpoint = "/api/v1/oauth/oauth-access-tokens?";

        List<Oauth2AccessTokenWithTenantNameResponse> response = ImmyBotApiService.Get<List<Oauth2AccessTokenWithTenantNameResponse>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
