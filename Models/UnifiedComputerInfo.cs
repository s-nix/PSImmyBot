using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record UnifiedComputerInfo(
    [property: JsonPropertyName("computerId")]
    int ComputerId,
    [property: JsonPropertyName("computerName")]
    string? ComputerName,
    [property: JsonPropertyName("isOnline")]
    bool IsOnline);
