using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetScriptVariablesAndParametersRequest(
    [property: JsonPropertyName("computerId")]
    int? ComputerId,
    [property: JsonPropertyName("scriptCategory")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<ScriptCategory>))]
    ScriptCategory ScriptCategory,
    [property: JsonPropertyName("scriptExecutionContext")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<ScriptExecutionContext>))]
    ScriptExecutionContext ScriptExecutionContext,
    [property: JsonPropertyName("softwareId")]
    int? SoftwareId,
    [property: JsonPropertyName("softwareType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<SoftwareType>))]
    SoftwareType SoftwareType,
    [property: JsonPropertyName("taskId")] int? TaskId,
    [property: JsonPropertyName("taskType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    DatabaseType TaskType,
    [property: JsonPropertyName("tenantId")]
    int? TenantId);
