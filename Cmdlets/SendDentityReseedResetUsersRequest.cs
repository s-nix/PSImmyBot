using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "DentityReseedResetUsersRequest")]
public class SendDentityReseedResetUsersRequest : Cmdlet {


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/identity-reseed/ResetUsers?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
