using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "GetRoleResponse")]
public class GetGetRoleResponse : Cmdlet {
    [Parameter(Mandatory = true)]
    public int RoleId { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/roles/{RoleId}?";

        GetRoleResponse response = ImmyBotApiService.Get<GetRoleResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
