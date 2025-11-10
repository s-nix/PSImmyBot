using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetCustomerPortalSessionResult(
    [property: JsonPropertyName("accessUrl")]
    string? AccessUrl,
    [property: JsonPropertyName("createdAt")]
    DateTimeOffset CreatedAt,
    [property: JsonPropertyName("customerId")]
    string? CustomerId,
    [property: JsonPropertyName("expiresAt")]
    DateTimeOffset? ExpiresAt,
    [property: JsonPropertyName("portalSessionId")]
    string? PortalSessionId,
    [property: JsonPropertyName("status")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<CustomerPortalSessionStatus>))]
    CustomerPortalSessionStatus Status,
    [property: JsonPropertyName("token")] string? Token);
