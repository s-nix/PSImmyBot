using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "ComputersEphemeralAgentCircuitBreakerReset")]
public class SendComputersEphemeralAgentCircuitBreakerReset : Cmdlet {
    [Parameter(Mandatory = true)]
    public int ComputerId { get; set; }



    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/computers/{ComputerId}/ephemeral-agent-circuit-breaker/reset?";

        OpResultCircuitBreakerState response = ImmyBotApiService.Post<OpResultCircuitBreakerState>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
