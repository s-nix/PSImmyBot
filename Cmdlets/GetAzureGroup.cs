using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "AzureGroup")]
public class GetAzureGroup : Cmdlet {
    [Parameter(Mandatory = true)]
    public required string AzureGroupId { get; set; }

    [Parameter(Mandatory = true)]
    public required int ImmyTenantId { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/tenants/{ImmyTenantId}/azure-groups/{AzureGroupId}?";

        GetAzureGroupResponse response = ImmyBotApiService.Get<GetAzureGroupResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
