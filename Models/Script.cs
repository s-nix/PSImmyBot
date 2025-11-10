using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

public record Script {
    [JsonConstructor]
    [Obsolete]
    public Script(string? @action, ICollection<ChangeRequest>? @changeRequests, int? @createdBy, User @createdByUser, DateTimeOffset @createdDate, DynamicIntegrationType @dynamicIntegrationType, DynamicIntegrationTypeProperties @dynamicIntegrationTypeProperties, string? @dynamicProviderStoreId, ActionPreference @errorActionPreference, bool @hidden, int @id, string? @identifier, InventoryTaskScript @inventoryTaskScript, string? @name, ScriptOutputType @outputType, IDictionary<string, object?>? @parameterOverrides, IDictionary<string, object?>? @parameters, int? @providerLinkIdForMaintenanceItem, string? @publicStorageDownloadUrl, bool @readOnly, string? @scriptCacheName, ScriptCategory @scriptCategory, ScriptExecutionContext @scriptExecutionContext, string? @scriptHash, ScriptLanguage @scriptLanguage, DatabaseType @scriptType, bool @skipBusinessHoursCheck, bool @skipPreflight, ICollection<TenantScript>? @tenantRelationships, int? @timeout, int? @updatedBy, User @updatedByUser, DateTimeOffset @updatedDate, IDictionary<string, object?>? @variables) {
        CreatedDate = @createdDate;
        UpdatedDate = @updatedDate;
        CreatedBy = @createdBy;
        UpdatedBy = @updatedBy;
        Name = @name;
        Id = @id;
        Action = @action;
        ScriptLanguage = @scriptLanguage;
        Timeout = @timeout;
        ScriptExecutionContext = @scriptExecutionContext;
        ScriptType = @scriptType;
        ReadOnly = @readOnly;
        Identifier = @identifier;
        ScriptCategory = @scriptCategory;
        OutputType = @outputType;
        PublicStorageDownloadUrl = @publicStorageDownloadUrl;
        ScriptHash = @scriptHash;
        ScriptCacheName = @scriptCacheName;
        Variables = @variables;
        Parameters = @parameters;
        ParameterOverrides = @parameterOverrides;
        DynamicProviderStoreId = @dynamicProviderStoreId;
        DynamicIntegrationTypeProperties = @dynamicIntegrationTypeProperties;
        ProviderLinkIdForMaintenanceItem = @providerLinkIdForMaintenanceItem;
        TenantRelationships = @tenantRelationships;
        ChangeRequests = @changeRequests;
        CreatedByUser = @createdByUser;
        UpdatedByUser = @updatedByUser;
        Hidden = @hidden;
        ErrorActionPreference = @errorActionPreference;
        SkipPreflight = @skipPreflight;
        SkipBusinessHoursCheck = @skipBusinessHoursCheck;
        DynamicIntegrationType = @dynamicIntegrationType;
        InventoryTaskScript = @inventoryTaskScript;
    }

    [JsonPropertyName("createdDate")]
    public DateTimeOffset CreatedDate { get; init; }

    [JsonPropertyName("updatedDate")]
    public DateTimeOffset UpdatedDate { get; init; }

    [JsonPropertyName("createdBy")]
    public int? CreatedBy { get; init; }

    [JsonPropertyName("updatedBy")]
    public int? UpdatedBy { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("id")]
    public int Id { get; init; }

    [JsonPropertyName("action")]
    public string? Action { get; init; }

    [JsonPropertyName("scriptLanguage")]
    [JsonConverter(typeof(JsonStringEnumConverter<ScriptLanguage>))]
    public ScriptLanguage ScriptLanguage { get; init; }

    [JsonPropertyName("timeout")]
    public int? Timeout { get; init; }

    [JsonPropertyName("scriptExecutionContext")]
    [JsonConverter(typeof(JsonStringEnumConverter<ScriptExecutionContext>))]
    public ScriptExecutionContext ScriptExecutionContext { get; init; }

    [JsonPropertyName("scriptType")]
    [JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    public DatabaseType ScriptType { get; init; }

    [JsonPropertyName("readOnly")]
    public bool ReadOnly { get; init; }

    [JsonPropertyName("identifier")]
    public string? Identifier { get; init; }

    [JsonPropertyName("scriptCategory")]
    [JsonConverter(typeof(JsonStringEnumConverter<ScriptCategory>))]
    public ScriptCategory ScriptCategory { get; init; }

    [JsonPropertyName("outputType")]
    [JsonConverter(typeof(JsonStringEnumConverter<ScriptOutputType>))]
    public ScriptOutputType OutputType { get; init; }

    [JsonPropertyName("publicStorageDownloadUrl")]
    public string? PublicStorageDownloadUrl { get; init; }

    [JsonPropertyName("scriptHash")]
    public string? ScriptHash { get; init; }

    [JsonPropertyName("scriptCacheName")]
    public string? ScriptCacheName { get; init; }

    [JsonPropertyName("variables")]
    public IDictionary<string, object?>? Variables { get; init; }

    [JsonPropertyName("parameters")]
    public IDictionary<string, object?>? Parameters { get; init; }

    [JsonPropertyName("parameterOverrides")]
    public IDictionary<string, object?>? ParameterOverrides { get; init; }

    [JsonPropertyName("dynamicProviderStoreId")]
    public string? DynamicProviderStoreId { get; init; }

    [JsonPropertyName("dynamicIntegrationTypeProperties")]
    public DynamicIntegrationTypeProperties DynamicIntegrationTypeProperties { get; init; }

    [JsonPropertyName("providerLinkIdForMaintenanceItem")]
    public int? ProviderLinkIdForMaintenanceItem { get; init; }

    [JsonPropertyName("tenantRelationships")]
    public ICollection<TenantScript>? TenantRelationships { get; init; }

    [JsonPropertyName("changeRequests")]
    public ICollection<ChangeRequest>? ChangeRequests { get; init; }

    [JsonPropertyName("createdByUser")]
    public User CreatedByUser { get; init; }

    [JsonPropertyName("updatedByUser")]
    public User UpdatedByUser { get; init; }

    [JsonPropertyName("hidden")]
    [Obsolete]
    public bool Hidden { get; init; }

    [JsonPropertyName("errorActionPreference")]
    [JsonConverter(typeof(JsonStringEnumConverter<ActionPreference>))]
    public ActionPreference ErrorActionPreference { get; init; }

    [JsonPropertyName("skipPreflight")]
    public bool SkipPreflight { get; init; }

    [JsonPropertyName("skipBusinessHoursCheck")]
    public bool SkipBusinessHoursCheck { get; init; }

    [JsonPropertyName("dynamicIntegrationType")]
    public DynamicIntegrationType DynamicIntegrationType { get; init; }

    [JsonPropertyName("inventoryTaskScript")]
    public InventoryTaskScript InventoryTaskScript { get; init; }
}
