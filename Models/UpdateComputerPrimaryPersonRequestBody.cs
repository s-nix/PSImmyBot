using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record UpdateComputerPrimaryPersonRequestBody(
    [property: JsonPropertyName("primaryPersonId")]
    int? PrimaryPersonId);
