using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetProductCatalogItemsResponse(
    [property: JsonPropertyName("addons")] ICollection<SubscriptionItemBasicInfo>? Addons,
    [property: JsonPropertyName("features")]
    ICollection<SubscriptionFeatureBasicInfo>? Features,
    [property: JsonPropertyName("plans")] ICollection<SubscriptionItemBasicInfo>? Plans);
