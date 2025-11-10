using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record RunImmybotPersonRequestBody(
    [property: JsonPropertyName("maintenanceTaskParameterValueOverrides")]
    IDictionary<string, IDictionary<string, DeploymentParameterValue>?>? MaintenanceTaskParameterValueOverrides,
    [property: JsonPropertyName("personId")]
    int PersonId);
