using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record BulkDeleteRequest([property: JsonPropertyName("ids")] ICollection<int>? Ids,
    [property: JsonPropertyName("permanent")]
    bool Permanent);
