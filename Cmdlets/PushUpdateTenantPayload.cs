using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Push", "UpdateTenantPayload")]
public class PushUpdateTenantPayload : Cmdlet {
    [Parameter(Mandatory = true)]
    public int Id { get; set; }


    [Parameter(Mandatory = true)] public required UpdateTenantPayload PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/tenants/{Id}?";

        GetTenantResponse response = ImmyBotApiService.Put<UpdateTenantPayload, GetTenantResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
