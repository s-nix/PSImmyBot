using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "SubscriptionFeatureBasicInfo")]
public class NewSubscriptionFeatureBasicInfo : Cmdlet {
    [Parameter(Mandatory = false)] public string? FeatureDescription { get; set; }
    [Parameter(Mandatory = false)] public string? FeatureId { get; set; }
    [Parameter(Mandatory = false)] public string? FeatureName { get; set; }
    [Parameter(Mandatory = true)] public required ICollection<SubscriptionFeatureLevelInfo> Levels { get; set; }
    [Parameter(Mandatory = true)] public required SubscriptionFeatureStatus Status { get; set; }
    [Parameter(Mandatory = true)] public required SubscriptionFeatureType Type { get; set; }
    [Parameter(Mandatory = false)] public string? Unit { get; set; }

    protected override void ProcessRecord() {
        SubscriptionFeatureBasicInfo outputObject = new(FeatureDescription, FeatureId, FeatureName, Levels, Status, Type, Unit);
        WriteObject(outputObject);
    }
}
