using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ScriptActionAudit(
    [property: JsonPropertyName("dateTimeUtc")]
    DateTimeOffset DateTimeUtc,
    [property: JsonPropertyName("newValue")]
    string? NewValue,
    [property: JsonPropertyName("oldValue")]
    string? OldValue,
    [property: JsonPropertyName("userDisplayName")]
    string? UserDisplayName);
