using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "RunImmyService")]
public class SendRunImmyService : Cmdlet
{
    [Parameter(Mandatory = true)]
    public required RunImmyServiceRequestBody PayloadBody { get; set; }

    protected override void ProcessRecord()
    {
        string endpoint = "/api/v1/run-immy-service?";
        RunImmyServiceResponseBody response = ImmyBotApiService
            .Post<RunImmyServiceRequestBody, RunImmyServiceResponseBody>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody)
            .GetAwaiter()
            .GetResult();
        WriteObject(response);
    }
}
