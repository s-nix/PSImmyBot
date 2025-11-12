using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "TenantPreferences")]
public class GetTenantPreferences : Cmdlet {
    [Parameter(Mandatory = true)]
    public int TenantId { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/preferences/tenants/{TenantId}?";

        TenantPreferences response = ImmyBotApiService.Get<TenantPreferences>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
