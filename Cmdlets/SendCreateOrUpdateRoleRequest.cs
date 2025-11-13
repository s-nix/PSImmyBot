using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "CreateOrUpdateRoleRequest")]
public class SendCreateOrUpdateRoleRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required CreateOrUpdateRoleRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/roles?";

        GetRoleResponse response = ImmyBotApiService.Post<CreateOrUpdateRoleRequest, GetRoleResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
