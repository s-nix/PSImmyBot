using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "IdentifyAgentRequest")]
public class SendIdentifyAgentRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required IdentifyAgentRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/provider-agents/identify?";

        OpResult response = ImmyBotApiService.Post<IdentifyAgentRequest, OpResult>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
