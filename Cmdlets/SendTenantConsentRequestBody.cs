using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "TenantConsentRequestBody")]
public class SendTenantConsentRequestBody : Cmdlet {

    [Parameter(Mandatory = true)] public required TenantConsentRequestBody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/azure/tenant-consented?";

        TenantConsentResponseBody response = ImmyBotApiService.Post<TenantConsentRequestBody, TenantConsentResponseBody>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
