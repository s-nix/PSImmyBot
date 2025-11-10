using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record RuntimeFieldHandle([property: JsonPropertyName("value")] IntPtr Value);
