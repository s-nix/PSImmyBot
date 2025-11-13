using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "CreateProviderLinkWithExternalProviderReferenceRequestBody")]
public class NewCreateProviderLinkWithExternalProviderReferenceRequestBody : Cmdlet {
    [Parameter(Mandatory = true)] public required ProviderLink ProviderLink { get; set; }
    [Parameter(Mandatory = true)] public required ProviderLinkExternalReferenceDataBody ProviderLinkExternalReferenceData { get; set; }

    protected override void ProcessRecord() {
        CreateProviderLinkWithExternalProviderReferenceRequestBody outputObject = new(ProviderLink, ProviderLinkExternalReferenceData);
        WriteObject(outputObject);
    }
}
