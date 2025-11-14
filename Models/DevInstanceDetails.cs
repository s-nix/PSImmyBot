using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record DevInstanceDetails(
    [property: JsonPropertyName("backendVersion")]
    string? BackendVersion,
    [property: JsonPropertyName("isHangfireServerRunning")]
    bool IsHangfireServerRunning,
    [property: JsonPropertyName("postRoutes")]
    IDictionary<string, string>? PostRoutes);
