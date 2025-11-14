using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "UpdateComputerRequestBody")]
public class NewUpdateComputerRequestBody : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<int>? AdditionalPersonIds { get; set; }
    [Parameter(Mandatory = false)] public string? Notes { get; set; }
    [Parameter(Mandatory = true)] public required ComputerOnboardingStatus OnboardingStatus { get; set; }
    [Parameter(Mandatory = false)] public ICollection<ProviderLinkUpdate>? ProviderLinkUpdates { get; set; }
    [Parameter(Mandatory = true)] public required int TenantId { get; set; }

    protected override void ProcessRecord() {
        UpdateComputerRequestBody outputObject = new(AdditionalPersonIds, Notes, OnboardingStatus, ProviderLinkUpdates, TenantId);
        WriteObject(outputObject);
    }
}
