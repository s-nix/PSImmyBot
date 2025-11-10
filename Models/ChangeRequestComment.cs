using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ChangeRequestComment(
    [property: JsonPropertyName("changeRequest")]
    ChangeRequest ChangeRequest,
    [property: JsonPropertyName("changeRequestId")]
    int ChangeRequestId,
    [property: JsonPropertyName("comment")]
    string? Comment,
    [property: JsonPropertyName("commentedByUsername")]
    string? CommentedByUsername,
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
