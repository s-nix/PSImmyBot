using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record DynamicIntegrationTypeResponse(
    [property: JsonPropertyName("createdDateUtc")]
    DateTimeOffset CreatedDateUtc,
    [property: JsonPropertyName("creationErrorMessage")]
    string? CreationErrorMessage,
    [property: JsonPropertyName("databaseType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    DatabaseType DatabaseType,
    [property: JsonPropertyName("docsUrl")]
    string? DocsUrl,
    [property: JsonPropertyName("enabled")]
    bool Enabled,
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("integrationTypeId")]
    Guid IntegrationTypeId,
    [property: JsonPropertyName("logo")] GlobalMediaResponse Logo,
    [property: JsonPropertyName("logoId")] int LogoId,
    [property: JsonPropertyName("name")] string? Name,
    [property: JsonPropertyName("scriptId")]
    int ScriptId,
    [property: JsonPropertyName("tag")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<IntegrationTag>))]
    IntegrationTag Tag,
    [property: JsonPropertyName("updatedDateUtc")]
    DateTimeOffset UpdatedDateUtc);
