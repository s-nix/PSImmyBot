using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record DefaultEmailBccList([property: JsonPropertyName("emails")] ICollection<string>? Emails);
