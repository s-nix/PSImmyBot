using System.Collections.Generic;
using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "TenantTargetPreview")]
public class SendTenantTargetPreview : Cmdlet
{
    [Parameter(Mandatory = true)]
    public required CalculateTargetsRequest PayloadBody { get; set; }

    protected override void ProcessRecord()
    {
        string endpoint = "/api/v1/target-assignments/tenant-target-preview?";
        List<GetTenantResponse> response = ImmyBotApiService
            .Post<CalculateTargetsRequest, List<GetTenantResponse>>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody)
            .GetAwaiter()
            .GetResult();
        WriteObject(response);
    }
}
