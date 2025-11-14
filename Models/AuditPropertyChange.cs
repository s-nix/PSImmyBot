using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record AuditPropertyChange(
    [property: JsonPropertyName("newValue")]
    object? NewValue,
    [property: JsonPropertyName("oldValue")]
    object? OldValue,
    [property: JsonPropertyName("property")]
    string? Property);
