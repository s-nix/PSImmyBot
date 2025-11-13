using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "OauthOauthAccessTokensRefresh")]
public class SendOauthOauthAccessTokensRefresh : Cmdlet {
    [Parameter(Mandatory = true)]
    public int Id { get; set; }



    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/oauth/oauth-access-tokens/{Id}/refresh?";

        Oauth2AccessToken response = ImmyBotApiService.Post<Oauth2AccessToken>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
