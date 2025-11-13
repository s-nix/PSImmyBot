using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ProviderLinkInternalData")]
public class NewProviderLinkInternalData : Cmdlet {
    [Parameter(Mandatory = false)] public object? InternalData { get; set; }
    [Parameter(Mandatory = true)] public required ProviderLink ProviderLink { get; set; }
    [Parameter(Mandatory = true)] public required int ProviderLinkId { get; set; }

    protected override void ProcessRecord() {
        ProviderLinkInternalData outputObject = new(InternalData, ProviderLink, ProviderLinkId);
        WriteObject(outputObject);
    }
}
