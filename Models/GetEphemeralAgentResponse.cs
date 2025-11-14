using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetEphemeralAgentResponse(
    [property: JsonPropertyName("createdAt")]
    DateTimeOffset CreatedAt, [property: JsonPropertyName("id")] Guid Id,
    [property: JsonPropertyName("isConnected")]
    bool IsConnected,
    [property: JsonPropertyName("lastActivity")]
    DateTimeOffset LastActivity,
    [property: JsonPropertyName("startupInfo")]
    AgentStartupInfo StartupInfo,
    [property: JsonPropertyName("totalProcessedScriptCount")]
    int TotalProcessedScriptCount,
    [property: JsonPropertyName("totalReceievedBytes")]
    int TotalReceievedBytes,
    [property: JsonPropertyName("totalSentBytes")]
    int TotalSentBytes);
