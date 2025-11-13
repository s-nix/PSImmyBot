using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetSubscriptionDetailsResponse")]
public class NewGetSubscriptionDetailsResponse : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<FeatureEnabledFromSubscription>? FeaturesEnabledFromSubscription { get; set; }
    [Parameter(Mandatory = false)] public string? PlanId { get; set; }
    [Parameter(Mandatory = true)] public required SubscriptionStatus Status { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? SubscriptionActivatedDateUtc { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? TrialEndUtc { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? TrialStartUtc { get; set; }

    protected override void ProcessRecord() {
        GetSubscriptionDetailsResponse outputObject = new(FeaturesEnabledFromSubscription, PlanId, Status, SubscriptionActivatedDateUtc, TrialEndUtc, TrialStartUtc);
        WriteObject(outputObject);
    }
}
