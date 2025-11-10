using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ToggleApplicationLogStreamingRequest(
    [property: JsonPropertyName("enabled")]
    bool Enabled);
