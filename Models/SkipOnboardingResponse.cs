using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record SkipOnboardingResponse(
    [property: JsonPropertyName("computerId")]
    int ComputerId,
    [property: JsonPropertyName("message")]
    string? Message,
    [property: JsonPropertyName("success")]
    bool Success);
