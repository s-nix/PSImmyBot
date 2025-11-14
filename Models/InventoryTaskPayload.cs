using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record InventoryTaskPayload(
    [property: JsonPropertyName("frequency")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<InventoryTaskFrequency>))]
    InventoryTaskFrequency Frequency, [property: JsonPropertyName("name")] string? Name);
