using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "DeleteAzureTenantAuthDetailsCmdPayloadRequest")]
public class SendDeleteAzureTenantAuthDetailsCmdPayloadRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required DeleteAzureTenantAuthDetailsCmdPayload PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/auth/delete-azure-tenant-auth-details?";

        DeleteAzureTenantAuthDetailsCmdResult response = ImmyBotApiService.Post<DeleteAzureTenantAuthDetailsCmdPayload, DeleteAzureTenantAuthDetailsCmdResult>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
