using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "RerunSessionsRequestBodyRequest")]
public class SendRerunSessionsRequestBodyRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required RerunSessionsRequestBody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/maintenance-sessions/rerun?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
    }

}
