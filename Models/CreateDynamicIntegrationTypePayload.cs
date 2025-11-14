using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record CreateDynamicIntegrationTypePayload(
    [property: JsonPropertyName("docsUrl")]
    string? DocsUrl,
    [property: JsonPropertyName("enabled")]
    bool Enabled,
    [property: JsonPropertyName("integrationTypeId")]
    Guid IntegrationTypeId,
    [property: JsonPropertyName("logoId")] int LogoId, [property: JsonPropertyName("name")] string? Name,
    [property: JsonPropertyName("scriptId")]
    int ScriptId,
    [property: JsonPropertyName("tag")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<IntegrationTag>))]
    IntegrationTag Tag);
