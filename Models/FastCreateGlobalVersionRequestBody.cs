using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record FastCreateGlobalVersionRequestBody(
    [property: JsonPropertyName("software")]
    CreateGlobalSoftwareRequestBody Software,
    [property: JsonPropertyName("softwareId")]
    int? SoftwareId,
    [property: JsonPropertyName("softwareVersion")]
    CreateGlobalSoftwareVersionRequestBody SoftwareVersion);
