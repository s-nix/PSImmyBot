using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetAgentSha256HashResponse(
    [property: JsonPropertyName("agentSha256Hash")]
    string? AgentSha256Hash,
    [property: JsonPropertyName("downloadUrl")]
    Uri? DownloadUrl);
