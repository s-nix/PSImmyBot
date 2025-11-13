using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "BulkDeleteRequest")]
public class SendBulkDeleteRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required BulkDeleteRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/tenants/bulk-delete?";

        DeleteTenantsCmdResponse response = ImmyBotApiService.Post<BulkDeleteRequest, DeleteTenantsCmdResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
