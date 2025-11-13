using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record Script(
    [property: JsonPropertyName("createdDate")]
    DateTimeOffset CreatedDate,

    [property: JsonPropertyName("updatedDate")]
    DateTimeOffset UpdatedDate,

    [property: JsonPropertyName("createdBy")]
    int? CreatedBy,

    [property: JsonPropertyName("updatedBy")]
    int? UpdatedBy,

    [property: JsonPropertyName("name")]
    string? Name,

    [property: JsonPropertyName("id")]
    int Id,

    [property: JsonPropertyName("action")]
    string? Action,

    [property: JsonPropertyName("scriptLanguage")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<ScriptLanguage>))]
    ScriptLanguage ScriptLanguage,

    [property: JsonPropertyName("timeout")]
    int? Timeout,

    [property: JsonPropertyName("scriptExecutionContext")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<ScriptExecutionContext>))]
    ScriptExecutionContext ScriptExecutionContext,

    [property: JsonPropertyName("scriptType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    DatabaseType ScriptType,

    [property: JsonPropertyName("readOnly")]
    bool ReadOnly,

    [property: JsonPropertyName("identifier")]
    string? Identifier,

    [property: JsonPropertyName("scriptCategory")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<ScriptCategory>))]
    ScriptCategory ScriptCategory,

    [property: JsonPropertyName("outputType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<ScriptOutputType>))]
    ScriptOutputType OutputType,

    [property: JsonPropertyName("publicStorageDownloadUrl")]
    string? PublicStorageDownloadUrl,

    [property: JsonPropertyName("scriptHash")]
    string? ScriptHash,

    [property: JsonPropertyName("scriptCacheName")]
    string? ScriptCacheName,

    [property: JsonPropertyName("variables")]
    IDictionary<string, object?>? Variables,

    [property: JsonPropertyName("parameters")]
    IDictionary<string, object?>? Parameters,

    [property: JsonPropertyName("parameterOverrides")]
    IDictionary<string, object?>? ParameterOverrides,

    [property: JsonPropertyName("dynamicProviderStoreId")]
    string? DynamicProviderStoreId,

    [property: JsonPropertyName("dynamicIntegrationTypeProperties")]
    DynamicIntegrationTypeProperties DynamicIntegrationTypeProperties,

    [property: JsonPropertyName("providerLinkIdForMaintenanceItem")]
    int? ProviderLinkIdForMaintenanceItem,

    [property: JsonPropertyName("tenantRelationships")]
    ICollection<TenantScript>? TenantRelationships,

    [property: JsonPropertyName("changeRequests")]
    ICollection<ChangeRequest>? ChangeRequests,

    [property: JsonPropertyName("createdByUser")]
    User CreatedByUser,

    [property: JsonPropertyName("updatedByUser")]
    User UpdatedByUser,

    [property: JsonPropertyName("hidden")]
    [property: Obsolete]
    bool Hidden,

    [property: JsonPropertyName("errorActionPreference")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<ActionPreference>))]
    ActionPreference ErrorActionPreference,

    [property: JsonPropertyName("skipPreflight")]
    bool SkipPreflight,

    [property: JsonPropertyName("skipBusinessHoursCheck")]
    bool SkipBusinessHoursCheck,

    [property: JsonPropertyName("dynamicIntegrationType")]
    DynamicIntegrationType DynamicIntegrationType,

    [property: JsonPropertyName("inventoryTaskScript")]
    InventoryTaskScript InventoryTaskScript
);
