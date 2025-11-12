using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "OpResultCircuitBreakerState")]
public class GetOpResultCircuitBreakerState : Cmdlet {
    [Parameter(Mandatory = true)]
    public int ComputerId { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/computers/{ComputerId}/ephemeral-agent-circuit-breaker?";

        OpResultCircuitBreakerState response = ImmyBotApiService.Get<OpResultCircuitBreakerState>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
