using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record MaintenanceTaskParameterValueDetails(
    [property: JsonPropertyName("allowOverrideFromComputerOnboarding")]
    bool AllowOverrideFromComputerOnboarding,
    [property: JsonPropertyName("deploymentId")]
    int DeploymentId,
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("maintenanceTaskId")]
    int MaintenanceTaskId,
    [property: JsonPropertyName("maintenanceTaskParameterId")]
    int MaintenanceTaskParameterId,
    [property: JsonPropertyName("maintenanceTaskType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    DatabaseType MaintenanceTaskType,
    [property: JsonPropertyName("mediaDatabaseType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    DatabaseType MediaDatabaseType,
    [property: JsonPropertyName("mediaId")]
    int? MediaId,
    [property: JsonPropertyName("parameterName")]
    string? ParameterName,
    [property: JsonPropertyName("parameterType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<MaintenanceTaskParameterType>))]
    MaintenanceTaskParameterType ParameterType,
    [property: JsonPropertyName("value")] string? Value);
