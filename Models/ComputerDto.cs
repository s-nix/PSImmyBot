using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ComputerDto(
    [property: JsonPropertyName("computerId")]
    int ComputerId,
    [property: JsonPropertyName("deployments")]
    ICollection<ComputerInDeploymentDto>? Deployments);
