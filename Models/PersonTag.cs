using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record PersonTag(
    [property: JsonPropertyName("entityId")]
    int EntityId,
    [property: JsonPropertyName("person")] Person Person,
    [property: JsonPropertyName("tag")] Tag Tag,
    [property: JsonPropertyName("tagId")] int TagId);
