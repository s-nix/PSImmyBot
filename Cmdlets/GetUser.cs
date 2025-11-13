using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "User")]
public class GetUser : Cmdlet {
    [Parameter(Mandatory = true)]
    public int UserId { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/users/{UserId}?";

        GetUserResponse response = ImmyBotApiService.Get<GetUserResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
