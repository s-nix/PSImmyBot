using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Update", "TenantsDeactivate")]
public class UpdateTenantsDeactivate : Cmdlet {
    [Parameter(Mandatory = true)]
    public int Id { get; set; }



    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/tenants/deactivate/{Id}?";

        ImmyBotApiService.Patch(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
