using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ProviderLinkUpdate")]
public class NewProviderLinkUpdate : Cmdlet {
    [Parameter(Mandatory = false)] public string? ClientId { get; set; }
    [Parameter(Mandatory = false)] public object? DeviceUpdateFormData { get; set; }
    [Parameter(Mandatory = true)] public required int ProviderLinkId { get; set; }

    protected override void ProcessRecord() {
        ProviderLinkUpdate outputObject = new(ClientId, DeviceUpdateFormData, ProviderLinkId);
        WriteObject(outputObject);
    }
}
