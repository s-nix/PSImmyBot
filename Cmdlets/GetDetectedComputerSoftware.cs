using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "DetectedComputerSoftware")]
public class GetDetectedComputerSoftware : Cmdlet {
    [Parameter(Mandatory = false)]
    public DataSourceLoadOptions? LoadOptions { get; set; }

    [Parameter(Mandatory = false)]
    public int? TenantId { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/tenants/software-from-inventory/dx?";
        endpoint += Globals.ConvertToQueryParameters(LoadOptions);
        endpoint += Globals.ConvertToQueryParameters(TenantId, "tenantId");

        List<DetectedComputerSoftwareResponse> response = ImmyBotApiService.Get<List<DetectedComputerSoftwareResponse>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
