using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ComputerInDeploymentDto(
    [property: JsonPropertyName("databaseType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<DatabaseType>))]
    DatabaseType DatabaseType,
    [property: JsonPropertyName("deploymentId")]
    int DeploymentId);
