using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record RuntimeMethodHandle([property: JsonPropertyName("value")] IntPtr Value);
