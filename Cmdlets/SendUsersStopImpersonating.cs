using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "UsersStopImpersonating")]
public class SendUsersStopImpersonating : Cmdlet {


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/users/stop-impersonating?";

        OpResult response = ImmyBotApiService.Post<OpResult>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
