using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "MetricsCircuitBreakersResetRequest")]
public class SendMetricsCircuitBreakersResetRequest : Cmdlet {
    [Parameter(Mandatory = false)]
    public string? PolicyName { get; set; }



    protected override void ProcessRecord() {
        string endpoint = "/api/v1/metrics/circuit-breakers/reset?";
        endpoint += Globals.ConvertToQueryParameters(PolicyName, "policyName");

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
