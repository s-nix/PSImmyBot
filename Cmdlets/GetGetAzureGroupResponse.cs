using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "GetAzureGroupResponse")]
public class GetGetAzureGroupResponse : Cmdlet {
    [Parameter(Mandatory = true)]
    public required string GroupId { get; set; }

    [Parameter(Mandatory = true)]
    public int Id { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/tenants/{Id}/azure-groups/{GroupId}?";

        GetAzureGroupResponse response = ImmyBotApiService.Get<GetAzureGroupResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
