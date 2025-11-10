using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record LoadResult([property: JsonPropertyName("data")] ICollection<object>? Data,
    [property: JsonPropertyName("groupCount")]
    int GroupCount,
    [property: JsonPropertyName("summary")]
    ICollection<object>? Summary,
    [property: JsonPropertyName("totalCount")]
    int TotalCount);
