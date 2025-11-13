using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "RequestSessionSupportRequestBodyRequest")]
public class SendRequestSessionSupportRequestBodyRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required RequestSessionSupportRequestBody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/system/request-session-support?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
    }

}
