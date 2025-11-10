using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ResolveFailuresRequestBody(
    [property: JsonPropertyName("agentIds")]
    ICollection<int>? AgentIds,
    [property: JsonPropertyName("allAgents")]
    bool AllAgents);
