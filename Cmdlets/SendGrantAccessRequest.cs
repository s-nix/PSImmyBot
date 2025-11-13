using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "GrantAccessRequest")]
public class SendGrantAccessRequest : Cmdlet {
    [Parameter(Mandatory = true)]
    public int PersonId { get; set; }


    [Parameter(Mandatory = true)] public required GrantAccessRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/persons/{PersonId}/grant-access?";

        CommandResult response = ImmyBotApiService.Post<GrantAccessRequest, CommandResult>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
