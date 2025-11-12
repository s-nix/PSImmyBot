using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "CreateTenantRequestBodyRequest")]
public class SendCreateTenantRequestBodyRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required CreateTenantRequestBody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/tenants?";

        GetTenantResponse response = ImmyBotApiService.Post<CreateTenantRequestBody, GetTenantResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
