using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "DentityReseedResetRoles")]
public class SendDentityReseedResetRoles : Cmdlet {


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/identity-reseed/ResetRoles?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
