using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "SubscriptionItemBasicInfo")]
public class NewSubscriptionItemBasicInfo : Cmdlet {
    [Parameter(Mandatory = false)] public string? ItemDescription { get; set; }
    [Parameter(Mandatory = false)] public string? ItemId { get; set; }
    [Parameter(Mandatory = false)] public string? ItemName { get; set; }
    [Parameter(Mandatory = true)] public required SubscriptionItemType ItemType { get; set; }

    protected override void ProcessRecord() {
        SubscriptionItemBasicInfo outputObject = new(ItemDescription, ItemId, ItemName, ItemType);
        WriteObject(outputObject);
    }
}
