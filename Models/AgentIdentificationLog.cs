using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record AgentIdentificationLog([property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("logType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<AgentIdentificationLogType>))]
    AgentIdentificationLogType LogType,
    [property: JsonPropertyName("message")]
    string? Message,
    [property: JsonPropertyName("providerAgent")]
    ProviderAgent ProviderAgent,
    [property: JsonPropertyName("providerAgentId")]
    int ProviderAgentId,
    [property: JsonPropertyName("timeUtc")]
    DateTimeOffset TimeUtc);
