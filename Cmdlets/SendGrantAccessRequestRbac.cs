using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "GrantAccessRequestRbac")]
public class SendGrantAccessRequestRbac : Cmdlet {

    [Parameter(Mandatory = true)] public required GrantAccessRequestRbac PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/users/grant-access?";

        CommandResult response = ImmyBotApiService.Post<GrantAccessRequestRbac, CommandResult>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
