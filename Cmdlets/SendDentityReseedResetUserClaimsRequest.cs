using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "DentityReseedResetUserClaimsRequest")]
public class SendDentityReseedResetUserClaimsRequest : Cmdlet {


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/identity-reseed/ResetUserClaims?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
