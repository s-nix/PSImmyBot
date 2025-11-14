using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetProductCatalogItemsResponse")]
public class NewGetProductCatalogItemsResponse : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<SubscriptionItemBasicInfo>? Addons { get; set; }
    [Parameter(Mandatory = false)] public ICollection<SubscriptionFeatureBasicInfo>? Features { get; set; }
    [Parameter(Mandatory = false)] public ICollection<SubscriptionItemBasicInfo>? Plans { get; set; }

    protected override void ProcessRecord() {
        GetProductCatalogItemsResponse outputObject = new(Addons, Features, Plans);
        WriteObject(outputObject);
    }
}
