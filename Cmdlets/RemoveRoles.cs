using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Remove", "Roles")]
public class RemoveRoles : Cmdlet {
    [Parameter(Mandatory = true)]
    public int RoleId { get; set; }



    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/roles/{RoleId}?";

        ImmyBotApiService.Delete(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
