using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record TenantScript(
    [property: JsonPropertyName("relationship")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<Relationship>))]
    Relationship Relationship,
    [property: JsonPropertyName("script")] Script Script,
    [property: JsonPropertyName("scriptId")]
    int ScriptId,
    [property: JsonPropertyName("tenant")] Tenant Tenant,
    [property: JsonPropertyName("tenantId")]
    int TenantId);
