using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ProviderLinkExternalReferenceDataBody")]
public class NewProviderLinkExternalReferenceDataBody : Cmdlet {
    [Parameter(Mandatory = true)] public required bool EnableClientExternalLinking { get; set; }
    [Parameter(Mandatory = true)] public required int ProviderLinkId { get; set; }
    [Parameter(Mandatory = true)] public required object ProviderTypeFormData { get; set; }

    protected override void ProcessRecord() {
        ProviderLinkExternalReferenceDataBody outputObject = new(EnableClientExternalLinking, ProviderLinkId, ProviderTypeFormData);
        WriteObject(outputObject);
    }
}
