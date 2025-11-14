using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record DeleteTenantsCmdResponse(
    [property: JsonPropertyName("message")]
    string? Message,
    [property: JsonPropertyName("success")]
    bool Success,
    [property: JsonPropertyName("tenantResults")]
    ICollection<DeleteTenantResult>? TenantResults);
