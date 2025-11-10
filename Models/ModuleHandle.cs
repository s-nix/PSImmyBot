using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ModuleHandle(
    [property: JsonPropertyName("mdStreamVersion")]
    int MdStreamVersion);
