using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "SetExcludedFromUserAffinityRequestBodyRequest")]
public class SendSetExcludedFromUserAffinityRequestBodyRequest : Cmdlet {
    [Parameter(Mandatory = true)]
    public int ComputerId { get; set; }


    [Parameter(Mandatory = true)] public required SetExcludedFromUserAffinityRequestBody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/computers/{ComputerId}/exclude-from-user-affinity?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
    }

}
