using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ExcludeFromMaintenanceRequest(
    [property: JsonPropertyName("exclude")]
    bool Exclude);
