using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "CreateUserFromPersonRequestRequest")]
public class SendCreateUserFromPersonRequestRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required CreateUserFromPersonRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/users/create-from-person?";

        GetUserResponse response = ImmyBotApiService.Post<CreateUserFromPersonRequest, GetUserResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
