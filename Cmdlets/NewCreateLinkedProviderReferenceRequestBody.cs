using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "CreateLinkedProviderReferenceRequestBody")]
public class NewCreateLinkedProviderReferenceRequestBody : Cmdlet {
    [Parameter(Mandatory = true)] public required bool IsCrossProviderClientExternalLinkingEnabled { get; set; }
    [Parameter(Mandatory = true)] public required int ProviderLinkId { get; set; }

    protected override void ProcessRecord() {
        CreateLinkedProviderReferenceRequestBody outputObject = new(IsCrossProviderClientExternalLinkingEnabled, ProviderLinkId);
        WriteObject(outputObject);
    }
}
