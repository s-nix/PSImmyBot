using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "TenantComputerCountResponse")]
public class GetTenantComputerCountResponse : Cmdlet {

    protected override void ProcessRecord() {
        string endpoint = "/api/v1/tenants/computer-counts?";

        List<TenantComputerCountResponse> response = ImmyBotApiService.Get<List<TenantComputerCountResponse>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
