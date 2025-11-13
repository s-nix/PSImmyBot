using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "GetCommandResult")]
public class GetGetCommandResult : Cmdlet {

    protected override void ProcessRecord() {
        string endpoint = "/api/v1/scripts/functions?";

        List<GetCommandResult> response = ImmyBotApiService.Get<List<GetCommandResult>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
