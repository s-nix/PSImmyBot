using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ComputerInventorySoftware(
    [property: JsonPropertyName("computers")]
    int Computers,
    [property: JsonPropertyName("displayName")]
    string? DisplayName,
    [property: JsonPropertyName("displayVersion")]
    string? DisplayVersion,
    [property: JsonPropertyName("upgradeCode")]
    Guid? UpgradeCode);
