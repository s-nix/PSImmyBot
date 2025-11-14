using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Push", "CreateOrUpdateRoleRequest")]
public class PushCreateOrUpdateRoleRequest : Cmdlet {
    [Parameter(Mandatory = true)]
    public int RoleId { get; set; }


    [Parameter(Mandatory = true)] public required CreateOrUpdateRoleRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/roles/{RoleId}?";

        GetRoleResponse response = ImmyBotApiService.Put<CreateOrUpdateRoleRequest, GetRoleResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
