using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record MaintenanceActionDependency(
    [property: JsonPropertyName("dependent")]
    MaintenanceAction Dependent,
    [property: JsonPropertyName("dependentId")]
    int DependentId,
    [property: JsonPropertyName("dependsOn")]
    MaintenanceAction DependsOn,
    [property: JsonPropertyName("dependsOnId")]
    int DependsOnId);
