using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "AzureTenantAuthDetails")]
public class GetAzureTenantAuthDetails : Cmdlet {
    [Parameter(Mandatory = true)]
    public required string AzureTenantPrincipalId { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/auth/get-azure-tenant-auth-details/{AzureTenantPrincipalId}?";

        AzureTenantAuthDetails response = ImmyBotApiService.Get<AzureTenantAuthDetails>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
