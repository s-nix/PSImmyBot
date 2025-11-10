using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ChangeRequestCommentResponse(
    [property: JsonPropertyName("changeRequestId")]
    int ChangeRequestId,
    [property: JsonPropertyName("comment")]
    string? Comment,
    [property: JsonPropertyName("commentedByUsername")]
    string? CommentedByUsername,
    [property: JsonPropertyName("createdDateUtc")]
    DateTimeOffset CreatedDateUtc, [property: JsonPropertyName("id")] int Id);
