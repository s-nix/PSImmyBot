using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record RunImmybotComputerRequestBody(
    [property: JsonPropertyName("computerId")]
    int ComputerId,
    [property: JsonPropertyName("maintenanceTaskParameterValueOverrides")]
    IDictionary<string, IDictionary<string, DeploymentParameterValue>?>? MaintenanceTaskParameterValueOverrides);
