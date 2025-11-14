using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "DentityReseedResetUserClaims")]
public class SendDentityReseedResetUserClaims : Cmdlet {


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/identity-reseed/ResetUserClaims?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
