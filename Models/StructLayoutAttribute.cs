using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record StructLayoutAttribute([property: JsonPropertyName("typeId")] object? TypeId, [property: JsonPropertyName("value")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<LayoutKind>))]
    LayoutKind Value);
