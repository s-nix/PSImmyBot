using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ChangeRequestDiff(
    [property: JsonPropertyName("newDeploymentDescription")]
    string? NewDeploymentDescription,
    [property: JsonPropertyName("oldDeploymentDescription")]
    string? OldDeploymentDescription,
    [property: JsonPropertyName("parameterDiffs")]
    ICollection<ChangeRequestParameterDiff>? ParameterDiffs);
