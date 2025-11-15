using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "AzureErrorLogItemsForTenant")]
public class GetAzureErrorLogItemsForTenant : Cmdlet {
    [Parameter(Mandatory = false)]
    public DataSourceLoadOptions? LoadOptions { get; set; }

    [Parameter(Mandatory = true)]
    public required string TenantPrincipalId { get; set; }

    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/azure-errors/for-tenant/{TenantPrincipalId}/dx?";
        endpoint += Globals.ConvertToQueryParameters(LoadOptions);

        List<AzureErrorLogItem> response = ImmyBotApiService.Get<List<AzureErrorLogItem>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
