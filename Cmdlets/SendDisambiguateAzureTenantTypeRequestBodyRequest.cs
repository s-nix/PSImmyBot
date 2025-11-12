using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "DisambiguateAzureTenantTypeRequestBodyRequest")]
public class SendDisambiguateAzureTenantTypeRequestBodyRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required DisambiguateAzureTenantTypeRequestBody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/azure/disambiguate-azure-tenant-type?";

        CheckTenantPartnerStatusResponseBody response = ImmyBotApiService.Post<DisambiguateAzureTenantTypeRequestBody, CheckTenantPartnerStatusResponseBody>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
