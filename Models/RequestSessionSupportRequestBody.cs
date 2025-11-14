using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record RequestSessionSupportRequestBody(
    [property: JsonPropertyName("allowTechnicianAccess")]
    bool? AllowTechnicianAccess,
    [property: JsonPropertyName("includeSessionData")]
    bool IncludeSessionData,
    [property: JsonPropertyName("sessionId")]
    int SessionId,
    [property: JsonPropertyName("ticketNotes")]
    string? TicketNotes,
    [property: JsonPropertyName("ticketSubject")]
    string? TicketSubject);
