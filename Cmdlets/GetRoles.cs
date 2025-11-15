using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "Roles")]
public class GetRoles : Cmdlet
{
    protected override void ProcessRecord()
    {
        string endpoint = "/api/v1/roles?";

        List<GetRoleResponse> response = ImmyBotApiService.Get<List<GetRoleResponse>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
