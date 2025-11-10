using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record InventoryTaskResource(
    [property: JsonPropertyName("createdDate")]
    DateTimeOffset CreatedDate,
    [property: JsonPropertyName("frequency")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<InventoryTaskFrequency>))]
    InventoryTaskFrequency Frequency,
    [property: JsonPropertyName("fromProvider")]
    bool FromProvider,
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("inventoryTaskType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    DatabaseType InventoryTaskType,
    [property: JsonPropertyName("name")] string? Name,
    [property: JsonPropertyName("scripts")]
    ICollection<InventoryTaskScriptResource>? Scripts,
    [property: JsonPropertyName("specifiedNumMinutes")]
    int? SpecifiedNumMinutes,
    [property: JsonPropertyName("updatedDate")]
    DateTimeOffset UpdatedDate);
