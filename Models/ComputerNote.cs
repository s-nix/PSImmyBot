using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ComputerNote(
    [property: JsonPropertyName("computer")]
    Computer Computer,
    [property: JsonPropertyName("computerId")]
    int ComputerId,
    [property: JsonPropertyName("content")]
    string? Content,
    [property: JsonPropertyName("createdBy")]
    int? CreatedBy,
    [property: JsonPropertyName("createdByUser")]
    User CreatedByUser,
    [property: JsonPropertyName("createdDate")]
    DateTimeOffset CreatedDate,
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("updatedBy")]
    int? UpdatedBy,
    [property: JsonPropertyName("updatedByUser")]
    User UpdatedByUser,
    [property: JsonPropertyName("updatedDate")]
    DateTimeOffset UpdatedDate);
