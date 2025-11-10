using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record AgentStartupInfo(
    [property: JsonPropertyName("installedAgentState")]
    AgentInstallationDetails InstalledAgentState, [property: JsonPropertyName("pid")] int Pid);
