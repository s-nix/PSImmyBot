using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record SubscriptionItemBasicInfo(
    [property: JsonPropertyName("itemDescription")]
    string? ItemDescription, [property: JsonPropertyName("itemId")] string? ItemId,
    [property: JsonPropertyName("itemName")]
    string? ItemName,
    [property: JsonPropertyName("itemType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<SubscriptionItemType>))]
    SubscriptionItemType ItemType);
