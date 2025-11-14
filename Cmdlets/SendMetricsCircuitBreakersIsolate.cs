using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "MetricsCircuitBreakersIsolate")]
public class SendMetricsCircuitBreakersIsolate : Cmdlet {
    [Parameter(Mandatory = false)]
    public string? PolicyName { get; set; }



    protected override void ProcessRecord() {
        string endpoint = "/api/v1/metrics/circuit-breakers/isolate?";
        endpoint += Globals.ConvertToQueryParameters(PolicyName, "policyName");

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
