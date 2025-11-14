using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record DynamicIntegrationType(
    [property: JsonPropertyName("createdDate")]
    DateTimeOffset CreatedDate,
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
    [property: JsonPropertyName("logo")] Media Logo,
    [property: JsonPropertyName("logoId")] int LogoId,
    [property: JsonPropertyName("name")] string? Name,
    [property: JsonPropertyName("script")] Script Script,
    [property: JsonPropertyName("scriptId")]
    int ScriptId,
    [property: JsonPropertyName("secrets")]
    object? Secrets,
    [property: JsonPropertyName("tag")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<IntegrationTag>))]
    IntegrationTag Tag,
    [property: JsonPropertyName("updatedDate")]
    DateTimeOffset UpdatedDate);
