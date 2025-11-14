using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record FastCreateLocalVersionRequestBody(
    [property: JsonPropertyName("software")]
    CreateLocalSoftwareRequestBody Software,
    [property: JsonPropertyName("softwareId")]
    int? SoftwareId,
    [property: JsonPropertyName("softwareVersion")]
    CreateLocalSoftwareVersionRequestBody SoftwareVersion);
