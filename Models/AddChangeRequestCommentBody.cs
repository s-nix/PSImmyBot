using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record AddChangeRequestCommentBody(
    [property: JsonPropertyName("comment")]
    string? Comment);
