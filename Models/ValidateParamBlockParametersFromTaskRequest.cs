using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ValidateParamBlockParametersFromTaskRequest(
    [property: JsonPropertyName("computerId")]
    int? ComputerId,
    [property: JsonPropertyName("databaseType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    DatabaseType DatabaseType,
    [property: JsonPropertyName("deploymentDatabaseType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    DatabaseType DeploymentDatabaseType,
    [property: JsonPropertyName("deploymentId")]
    int? DeploymentId,
    [property: JsonPropertyName("forceRebind")]
    bool ForceRebind,
    [property: JsonPropertyName("maintenanceSessionId")]
    int? MaintenanceSessionId,
    [property: JsonPropertyName("maintenanceTaskId")]
    int MaintenanceTaskId,
    [property: JsonPropertyName("parameterValues")]
    IDictionary<string, ParameterValue>? ParameterValues,
    [property: JsonPropertyName("personId")]
    int? PersonId,
    [property: JsonPropertyName("tenantId")]
    int? TenantId,
    [property: JsonPropertyName("terminalId")]
    Guid? TerminalId);
