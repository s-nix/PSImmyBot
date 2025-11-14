using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Update", "TenantsActivate")]
public class UpdateTenantsActivate : Cmdlet {
    [Parameter(Mandatory = true)]
    public int Id { get; set; }



    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/tenants/activate/{Id}?";

        ImmyBotApiService.Patch(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
