using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record RunImmybotTenantRequestBody(
    [property: JsonPropertyName("maintenanceTaskParameterValueOverrides")]
    IDictionary<string, IDictionary<string, DeploymentParameterValue>?>? MaintenanceTaskParameterValueOverrides,
    [property: JsonPropertyName("tenantId")]
    int TenantId);
