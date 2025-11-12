using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "IDeviceGroup")]
public class GetIDeviceGroup : Cmdlet {
    [Parameter(Mandatory = true)]
    public required string DeviceGroupTypeId { get; set; }

    [Parameter(Mandatory = false)]
    public int? ProviderLinkId { get; set; }

    [Parameter(Mandatory = false)]
    public string? ExternalClientId { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/provider-types/device-group-types/{DeviceGroupTypeId}/device-groups?";
        endpoint += Globals.ConvertToQueryParameters(ProviderLinkId, "providerLinkId");
        endpoint += Globals.ConvertToQueryParameters(ExternalClientId, "externalClientId");

        List<IDeviceGroup> response = ImmyBotApiService.Get<List<IDeviceGroup>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
