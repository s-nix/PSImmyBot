using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record AgentUpdateFormSchemaInput(
    [property: JsonPropertyName("default")]
    object? Default,
    [property: JsonPropertyName("description")]
    string? Description,
    [property: JsonPropertyName("deviceGroupTypeId")]
    Guid? DeviceGroupTypeId,
    [property: JsonPropertyName("label")] string? Label, [property: JsonPropertyName("name")] string? Name,
    [property: JsonPropertyName("required")]
    bool Required, [property: JsonPropertyName("type")] string? Type);
