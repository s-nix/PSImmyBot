using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record DeviceUpdateFormDataResponse(
    [property: JsonPropertyName("agentId")]
    int AgentId,
    [property: JsonPropertyName("deviceUpdateFormData")]
    object? DeviceUpdateFormData);
