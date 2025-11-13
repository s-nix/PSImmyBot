using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "UpdateAzureTenantAuthDetailsCmdPayloadRequest")]
public class SendUpdateAzureTenantAuthDetailsCmdPayloadRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required UpdateAzureTenantAuthDetailsCmdPayload PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/auth/update-azure-tenant-auth-details?";

        UpdateAzureTenantAuthDetailsCmdResult response = ImmyBotApiService.Post<UpdateAzureTenantAuthDetailsCmdPayload, UpdateAzureTenantAuthDetailsCmdResult>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
