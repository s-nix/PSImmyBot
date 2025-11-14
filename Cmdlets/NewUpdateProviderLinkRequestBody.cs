using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "UpdateProviderLinkRequestBody")]
public class NewUpdateProviderLinkRequestBody : Cmdlet {
    [Parameter(Mandatory = true)] public required bool Disabled { get; set; }
    [Parameter(Mandatory = false)] public ICollection<string>? ExcludedCapabilities { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = true)] public required object ProviderTypeFormData { get; set; }
    [Parameter(Mandatory = false)] public int? UpdatedBy { get; set; }

    protected override void ProcessRecord() {
        UpdateProviderLinkRequestBody outputObject = new(Disabled, ExcludedCapabilities, Id, Name, ProviderTypeFormData, UpdatedBy);
        WriteObject(outputObject);
    }
}
