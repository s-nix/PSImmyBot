using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "LinkedExternalLink")]
public class NewLinkedExternalLink : Cmdlet {
    [Parameter(Mandatory = true)] public required bool IsExternalClientLinkingEnabled { get; set; }
    [Parameter(Mandatory = true)] public required bool IsExternalProviderInitializedFromThisProvider { get; set; }
    [Parameter(Mandatory = true)] public required int ProviderLinkId { get; set; }
    [Parameter(Mandatory = false)] public string? ProviderLinkName { get; set; }
    [Parameter(Mandatory = true)] public required Guid ProviderTypeId { get; set; }

    protected override void ProcessRecord() {
        LinkedExternalLink outputObject = new(IsExternalClientLinkingEnabled, IsExternalProviderInitializedFromThisProvider, ProviderLinkId, ProviderLinkName, ProviderTypeId);
        WriteObject(outputObject);
    }
}
