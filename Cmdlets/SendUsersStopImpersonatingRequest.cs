using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "UsersStopImpersonatingRequest")]
public class SendUsersStopImpersonatingRequest : Cmdlet {


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/users/stop-impersonating?";

        OpResult response = ImmyBotApiService.Post<OpResult>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
