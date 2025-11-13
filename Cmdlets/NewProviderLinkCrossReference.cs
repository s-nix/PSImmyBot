using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ProviderLinkCrossReference")]
public class NewProviderLinkCrossReference : Cmdlet {
    [Parameter(Mandatory = true)] public required bool IsExternalClientLinkingEnabled { get; set; }
    [Parameter(Mandatory = true)] public required bool IsProviderLink2InitializedFromProviderLink1 { get; set; }
    [Parameter(Mandatory = true)] public required ProviderLink ProviderLink1 { get; set; }
    [Parameter(Mandatory = true)] public required int ProviderLink1Id { get; set; }
    [Parameter(Mandatory = true)] public required ProviderLink ProviderLink2 { get; set; }
    [Parameter(Mandatory = true)] public required int ProviderLink2Id { get; set; }

    protected override void ProcessRecord() {
        ProviderLinkCrossReference outputObject = new(IsExternalClientLinkingEnabled, IsProviderLink2InitializedFromProviderLink1, ProviderLink1, ProviderLink1Id, ProviderLink2, ProviderLink2Id);
        WriteObject(outputObject);
    }
}
