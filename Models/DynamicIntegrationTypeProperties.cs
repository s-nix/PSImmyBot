using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record DynamicIntegrationTypeProperties(
    [property: JsonPropertyName("databaseType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    DatabaseType DatabaseType,
    [property: JsonPropertyName("docsUrl")]
    string? DocsUrl,
    [property: JsonPropertyName("logoMediaId")]
    int LogoMediaId,
    [property: JsonPropertyName("name")] string? Name,
    [property: JsonPropertyName("providerTypeId")]
    Guid ProviderTypeId,
    [property: JsonPropertyName("secrets")]
    IDictionary<string, object>? Secrets);
