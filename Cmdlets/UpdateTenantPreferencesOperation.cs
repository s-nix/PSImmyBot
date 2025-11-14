using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Update", "TenantPreferencesOperation")]
public class UpdateTenantPreferencesOperation : Cmdlet {
    [Parameter(Mandatory = true)]
    public int TenantId { get; set; }


    [Parameter(Mandatory = true)] public required List<TenantPreferencesOperation> PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/preferences/tenants/{TenantId}?";

        TenantPreferences response = ImmyBotApiService.Patch<List<TenantPreferencesOperation>, TenantPreferences>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
