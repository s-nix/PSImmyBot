using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record BulkCreateTenantRequestBodyListItem(
    [property: JsonPropertyName("limitToDomains")]
    ICollection<string>? LimitToDomains, [property: JsonPropertyName("name")] string? Name,
    [property: JsonPropertyName("partnerPrincipalId")]
    string? PartnerPrincipalId,
    [property: JsonPropertyName("principalId")]
    string? PrincipalId,
    [property: JsonPropertyName("slug")] string? Slug);
