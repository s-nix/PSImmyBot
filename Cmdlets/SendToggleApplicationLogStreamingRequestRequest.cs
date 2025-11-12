using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "ToggleApplicationLogStreamingRequestRequest")]
public class SendToggleApplicationLogStreamingRequestRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required ToggleApplicationLogStreamingRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/application-logs/streaming?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
    }

}
