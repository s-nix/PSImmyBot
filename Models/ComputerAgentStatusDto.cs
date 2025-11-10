using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ComputerAgentStatusDto(
    [property: JsonPropertyName("agents")] ICollection<AgentStatusDto>? Agents,
    [property: JsonPropertyName("allAgentsConnected")]
    bool AllAgentsConnected,
    [property: JsonPropertyName("computerName")]
    string? ComputerName, [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("someConnected")]
    bool SomeConnected,
    [property: JsonPropertyName("tenantId")]
    int TenantId,
    [property: JsonPropertyName("tenantName")]
    string? TenantName);
