using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "SubscriptionDetails")]
public class NewSubscriptionDetails : Cmdlet {
    [Parameter(Mandatory = false)] public DateTimeOffset? ActivatedAtUtc { get; set; }
    [Parameter(Mandatory = false)] public ICollection<SubscriptionAddonDto>? Addons { get; set; }
    [Parameter(Mandatory = false)] public string? CustomerEmail { get; set; }
    [Parameter(Mandatory = false)] public string? CustomerId { get; set; }
    [Parameter(Mandatory = false)] public ICollection<SubscriptionFeature>? Features { get; set; }
    [Parameter(Mandatory = false)] public string? PlanId { get; set; }
    [Parameter(Mandatory = true)] public required int PlanPrice { get; set; }
    [Parameter(Mandatory = true)] public required int PlanQuantity { get; set; }
    [Parameter(Mandatory = true)] public required SubscriptionStatus Status { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? TrialEndUtc { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? TrialStartUtc { get; set; }

    protected override void ProcessRecord() {
        SubscriptionDetails outputObject = new(ActivatedAtUtc, Addons, CustomerEmail, CustomerId, Features, PlanId, PlanPrice, PlanQuantity, Status, TrialEndUtc, TrialStartUtc);
        WriteObject(outputObject);
    }
}
