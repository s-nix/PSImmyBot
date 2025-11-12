using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "UthRequestAccessRequest")]
public class SendUthRequestAccessRequest : Cmdlet {


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/auth/request-access?";

        CommandResult response = ImmyBotApiService.Post<CommandResult>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
