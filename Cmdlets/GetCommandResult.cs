using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "CommandResult")]
public class GetCommandResult : Cmdlet {

    protected override void ProcessRecord() {
        string endpoint = "/api/v1/scripts/functions?";

        List<CommandResultResponse> response = ImmyBotApiService.Get<List<CommandResultResponse>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
