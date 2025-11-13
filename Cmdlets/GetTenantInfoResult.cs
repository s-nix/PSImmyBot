using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "TenantInfoResult")]
public class GetTenantInfoResult : Cmdlet {

    protected override void ProcessRecord() {
        string endpoint = "/api/v1/azure/partner-tenant-infos?";

        List<TenantInfoResult> response = ImmyBotApiService.Get<List<TenantInfoResult>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
