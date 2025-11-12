using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "ErsonsDenyAccessRequest")]
public class SendErsonsDenyAccessRequest : Cmdlet {
    [Parameter(Mandatory = true)]
    public int PersonId { get; set; }



    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/persons/{PersonId}/deny-access?";

        CommandResult response = ImmyBotApiService.Post<CommandResult>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
