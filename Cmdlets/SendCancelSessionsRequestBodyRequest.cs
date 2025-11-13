using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "CancelSessionsRequestBodyRequest")]
public class SendCancelSessionsRequestBodyRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required CancelSessionsRequestBody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/maintenance-sessions/cancel?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
    }

}
