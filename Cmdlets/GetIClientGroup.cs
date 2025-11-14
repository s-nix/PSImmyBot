using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "IClientGroup")]
public class GetIClientGroup : Cmdlet {
    [Parameter(Mandatory = true)]
    public required string ClientGroupTypeId { get; set; }

    [Parameter(Mandatory = false)]
    public int? ProviderLinkId { get; set; }

    [Parameter(Mandatory = false)]
    public int? TenantId { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/provider-types/client-group-types/{ClientGroupTypeId}/client-groups?";
        endpoint += Globals.ConvertToQueryParameters(ProviderLinkId, "providerLinkId");
        endpoint += Globals.ConvertToQueryParameters(TenantId, "tenantId");

        List<IClientGroup> response = ImmyBotApiService.Get<List<IClientGroup>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
