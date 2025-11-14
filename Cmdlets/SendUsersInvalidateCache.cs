using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "UsersInvalidateCache")]
public class SendUsersInvalidateCache : Cmdlet {
    [Parameter(Mandatory = true)]
    public int UserId { get; set; }



    protected override void ProcessRecord() {
        string endpoint = "/api/v1/users/invalidate-cache?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
