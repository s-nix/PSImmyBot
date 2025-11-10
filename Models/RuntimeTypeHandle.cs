using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record RuntimeTypeHandle([property: JsonPropertyName("value")] IntPtr Value);
