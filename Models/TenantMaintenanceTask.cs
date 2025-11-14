using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record TenantMaintenanceTask(
    [property: JsonPropertyName("maintenanceTask")]
    MaintenanceTask MaintenanceTask,
    [property: JsonPropertyName("maintenanceTaskId")]
    int MaintenanceTaskId,
    [property: JsonPropertyName("relationship")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<Relationship>))]
    Relationship Relationship,
    [property: JsonPropertyName("tenant")] Tenant Tenant,
    [property: JsonPropertyName("tenantId")]
    int TenantId);
