using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record CancelSessionsRequestBody(
    [property: JsonPropertyName("sessionIds")]
    ICollection<int>? SessionIds);
