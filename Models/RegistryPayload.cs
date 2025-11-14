using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record RegistryPayload(
    [property: JsonPropertyName("keyPath")]
    string? KeyPath);
