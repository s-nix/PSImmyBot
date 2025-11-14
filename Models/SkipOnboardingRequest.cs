using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record SkipOnboardingRequest(
    [property: JsonPropertyName("computerId")]
    int ComputerId);
