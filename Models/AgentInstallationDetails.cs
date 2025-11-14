using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record AgentInstallationDetails(
    [property: JsonPropertyName("detectedInstalledVersion")]
    string? DetectedInstalledVersion,
    [property: JsonPropertyName("isApplicationRegistryEntryPresent")]
    bool IsApplicationRegistryEntryPresent,
    [property: JsonPropertyName("isServicePresent")]
    bool IsServicePresent,
    [property: JsonPropertyName("isServiceRunning")]
    bool IsServiceRunning,
    [property: JsonPropertyName("runningBinaryVersion")]
    string? RunningBinaryVersion);
