using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetScriptNameResponse(
    [property: JsonPropertyName("action")] string? Action,
    [property: JsonPropertyName("category")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<ScriptCategory>))]
    ScriptCategory Category, [property: JsonPropertyName("id")] int Id, [property: JsonPropertyName("name")] string? Name,
    [property: JsonPropertyName("updatedBy")]
    string? UpdatedBy,
    [property: JsonPropertyName("updatedDateUtc")]
    DateTimeOffset UpdatedDateUtc);
