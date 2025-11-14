using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "RemoveParentTenantRequest")]
public class SendRemoveParentTenantRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required RemoveParentTenantRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/tenants/remove-parent-tenant?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
    }

}
