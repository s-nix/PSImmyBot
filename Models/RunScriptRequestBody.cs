using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record RunScriptRequestBody(
    [property: JsonPropertyName("cancellationId")]
    Guid CancellationId,
    [property: JsonPropertyName("computerId")]
    int? ComputerId,
    [property: JsonPropertyName("maintenanceActionId")]
    int? MaintenanceActionId,
    [property: JsonPropertyName("maintenanceSessionId")]
    int? MaintenanceSessionId,
    [property: JsonPropertyName("maintenanceTaskId")]
    int? MaintenanceTaskId,
    [property: JsonPropertyName("maintenanceTaskType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    DatabaseType MaintenanceTaskType,
    [property: JsonPropertyName("script")]
    [property: System.ComponentModel.DataAnnotations.Required]
    Script Script,
    [property: JsonPropertyName("sessionLogId")]
    int? SessionLogId,
    [property: JsonPropertyName("tenantId")]
    int? TenantId,
    [property: JsonPropertyName("terminalId")]
    Guid? TerminalId);
