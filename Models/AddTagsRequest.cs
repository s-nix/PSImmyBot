using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record AddTagsRequest(
    [property: JsonPropertyName("entityIds")]
    ICollection<int>? EntityIds,
    [property: JsonPropertyName("tagIds")] ICollection<int>? TagIds);
