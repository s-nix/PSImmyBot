using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record UpdateNotesPayload([property: JsonPropertyName("notes")] string? Notes);
