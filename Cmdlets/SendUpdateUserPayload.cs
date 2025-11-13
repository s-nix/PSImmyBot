using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "UpdateUserPayload")]
public class SendUpdateUserPayload : Cmdlet {
    [Parameter(Mandatory = true)]
    public int UserId { get; set; }


    [Parameter(Mandatory = true)] public required UpdateUserPayload PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/users/{UserId}?";

        GetUserResponse response = ImmyBotApiService.Post<UpdateUserPayload, GetUserResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
