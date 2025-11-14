using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "BatchSetExcludedFromUserAffinityRequestBody")]
public class SendBatchSetExcludedFromUserAffinityRequestBody : Cmdlet {

    [Parameter(Mandatory = true)] public required BatchSetExcludedFromUserAffinityRequestBody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/computers/set-excluded-from-user-affinity?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
    }

}
