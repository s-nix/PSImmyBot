using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ComputerTag(
    [property: JsonPropertyName("computer")]
    Computer Computer,
    [property: JsonPropertyName("entityId")]
    int EntityId,
    [property: JsonPropertyName("tag")] Tag Tag,
    [property: JsonPropertyName("tagId")] int TagId);
