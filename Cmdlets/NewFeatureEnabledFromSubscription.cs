using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "FeatureEnabledFromSubscription")]
public class NewFeatureEnabledFromSubscription : Cmdlet {
    [Parameter(Mandatory = false)] public string? FeatureCustomValue { get; set; }
    [Parameter(Mandatory = true)] public required FeatureEntitlementType FeatureEntitlementType { get; set; }
    [Parameter(Mandatory = false)] public string? FeatureId { get; set; }
    [Parameter(Mandatory = true)] public required FeatureUsageDetails FeatureUsage { get; set; }
    [Parameter(Mandatory = true)] public required bool IsUsageBased { get; set; }

    protected override void ProcessRecord() {
        FeatureEnabledFromSubscription outputObject = new(FeatureCustomValue, FeatureEntitlementType, FeatureId, FeatureUsage, IsUsageBased);
        WriteObject(outputObject);
    }
}
