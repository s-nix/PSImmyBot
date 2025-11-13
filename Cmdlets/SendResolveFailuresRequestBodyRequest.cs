using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "ResolveFailuresRequestBodyRequest")]
public class SendResolveFailuresRequestBodyRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required ResolveFailuresRequestBody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/provider-agents/resolve-failures?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
    }

}
