using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record AzureSyncResult(
    [property: JsonPropertyName("attemptDateUtc")]
    DateTimeOffset AttemptDateUtc,
    [property: JsonPropertyName("attemptFailedErrorId")]
    Guid? AttemptFailedErrorId);
