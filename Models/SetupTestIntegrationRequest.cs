using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record SetupTestIntegrationRequest([property: JsonPropertyName("script")] string? Script);
