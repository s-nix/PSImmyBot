using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "DentityReseedResetClaimsRequest")]
public class SendDentityReseedResetClaimsRequest : Cmdlet {


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/identity-reseed/ResetClaims?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
