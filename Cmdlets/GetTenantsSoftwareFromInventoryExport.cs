using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "TenantsSoftwareFromInventoryExport")]
public class GetTenantsSoftwareFromInventoryExport : Cmdlet {
    [Parameter(Mandatory = false)]
    public DataSourceLoadOptions? LoadOptions { get; set; }

     [Parameter(Mandatory = false)]
    public int? TenantId { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/tenants/software-from-inventory/export?";
        endpoint += Globals.ConvertToQueryParameters(LoadOptions);
         endpoint += Globals.ConvertToQueryParameters(TenantId);

        byte[] response = ImmyBotApiService.Get<byte[]>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
