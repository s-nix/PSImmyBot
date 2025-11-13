using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "TenantSoftwareFromInventory")]
public class GetTenantSoftwareFromInventory : Cmdlet {
    [Parameter(Mandatory = true)]
    public int Id { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/tenants/software-from-inventory/{Id}?";

        List<GetTenantSoftwareFromInventoryResponse> response = ImmyBotApiService.Get<List<GetTenantSoftwareFromInventoryResponse>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
