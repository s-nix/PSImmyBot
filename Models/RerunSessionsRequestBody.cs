using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record RerunSessionsRequestBody(
    [property: JsonPropertyName("sessionIds")]
    ICollection<int>? SessionIds);
