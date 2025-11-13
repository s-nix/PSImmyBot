using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "BulkUpdateRoleRequest")]
public class SendBulkUpdateRoleRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required BulkUpdateRoleRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/users/add-roles?";

        string response = ImmyBotApiService.Post<BulkUpdateRoleRequest, string>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
