using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "SupportedCrossProviderLinkage")]
public class NewSupportedCrossProviderLinkage : Cmdlet {
    [Parameter(Mandatory = false)] public string? Description { get; set; }
    [Parameter(Mandatory = true)] public required Guid ProviderTypeId { get; set; }

    protected override void ProcessRecord() {
        SupportedCrossProviderLinkage outputObject = new(Description, ProviderTypeId);
        WriteObject(outputObject);
    }
}
