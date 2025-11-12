using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "CircuitBreakerState")]
public class GetCircuitBreakerState : Cmdlet {

    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/metrics/circuit-breakers?";

        List<CircuitBreakerState> response = ImmyBotApiService.Get<List<CircuitBreakerState>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
