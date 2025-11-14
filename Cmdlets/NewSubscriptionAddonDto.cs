using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "SubscriptionAddonDto")]
public class NewSubscriptionAddonDto : Cmdlet {
    [Parameter(Mandatory = false)] public string? AddonId { get; set; }
    [Parameter(Mandatory = false)] public int? Price { get; set; }
    [Parameter(Mandatory = false)] public int? Quantity { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? TrialEndUtc { get; set; }

    protected override void ProcessRecord() {
        SubscriptionAddonDto outputObject = new(AddonId, Price, Quantity, TrialEndUtc);
        WriteObject(outputObject);
    }
}
