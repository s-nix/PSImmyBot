using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "BulkCreateTenantRequestBody")]
public class SendBulkCreateTenantRequestBody : Cmdlet {

    [Parameter(Mandatory = true)] public required BulkCreateTenantRequestBody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/tenants/bulk-create?";

        List<GetTenantResponse> response = ImmyBotApiService.Post<BulkCreateTenantRequestBody, List<GetTenantResponse>>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
