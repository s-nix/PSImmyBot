using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "MetricsProviderLinks")]
public class GetMetricsProviderLinks : Cmdlet {

    protected override void ProcessRecord() {
        string endpoint = "/api/v1/metrics/provider-links?";

        byte[] response = ImmyBotApiService.Get<byte[]>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
