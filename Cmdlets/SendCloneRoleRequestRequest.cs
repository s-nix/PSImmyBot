using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "CloneRoleRequestRequest")]
public class SendCloneRoleRequestRequest : Cmdlet {
    [Parameter(Mandatory = true)]
    public int RoleId { get; set; }


    [Parameter(Mandatory = true)] public required CloneRoleRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/roles/{RoleId}/clone?";

        GetRoleResponse response = ImmyBotApiService.Post<CloneRoleRequest, GetRoleResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
