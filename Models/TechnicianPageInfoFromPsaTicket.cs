using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record TechnicianPageInfoFromPsaTicket(
    [property: JsonPropertyName("computers")]
    ICollection<UnifiedComputerInfo>? Computers,
    [property: JsonPropertyName("personId")]
    int? PersonId,
    [property: JsonPropertyName("personName")]
    string? PersonName,
    [property: JsonPropertyName("tenantId")]
    int? TenantId,
    [property: JsonPropertyName("tenantName")]
    string? TenantName,
    [property: JsonPropertyName("ticketClientId")]
    string? TicketClientId,
    [property: JsonPropertyName("ticketEmailAddress")]
    string? TicketEmailAddress);
