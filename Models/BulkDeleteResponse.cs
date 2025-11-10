using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record BulkDeleteResponse(
    [property: JsonPropertyName("numDeleted")]
    int NumDeleted);
