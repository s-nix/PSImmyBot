using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record IdentifyAgentRequest(
    [property: JsonPropertyName("agentIds")]
    ICollection<int>? AgentIds,
    [property: JsonPropertyName("tenantId")]
    int TenantId);
