using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ValidateParamBlockParametersFromScriptRequest(
    [property: JsonPropertyName("computerId")]
    int? ComputerId,
    [property: JsonPropertyName("databaseType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    DatabaseType DatabaseType,
    [property: JsonPropertyName("forceRebind")]
    bool ForceRebind,
    [property: JsonPropertyName("maintenanceSessionId")]
    int? MaintenanceSessionId,
    [property: JsonPropertyName("parameterValues")]
    IDictionary<string, ParameterValue>? ParameterValues,
    [property: JsonPropertyName("script")] string? Script,
    [property: JsonPropertyName("tenantId")]
    int? TenantId,
    [property: JsonPropertyName("terminalId")]
    Guid? TerminalId,
    [property: JsonPropertyName("validateRequiresOverrideForOnboarding")]
    bool ValidateRequiresOverrideForOnboarding);
