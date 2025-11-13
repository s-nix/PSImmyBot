using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "UpdateAzureTenantLinkRequest")]
public class SendUpdateAzureTenantLinkRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required UpdateAzureTenantLinkRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/tenants/update-azure-tenant-link?";

        GetTenantResponse response = ImmyBotApiService.Post<UpdateAzureTenantLinkRequest, GetTenantResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
