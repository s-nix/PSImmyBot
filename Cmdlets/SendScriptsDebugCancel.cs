using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "ScriptsDebugCancel")]
public class SendScriptsDebugCancel : Cmdlet {
    [Parameter(Mandatory = true)]
    public required string CancellationId { get; set; }



    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/scripts/debug/cancel/{CancellationId}?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
