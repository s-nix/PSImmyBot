using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record CreateTenantRequestBody(
    [property: JsonPropertyName("isMsp")] bool IsMsp,
    [property: JsonPropertyName("limitToDomains")]
    ICollection<string>? LimitToDomains, [property: JsonPropertyName("name")] string? Name,
    [property: JsonPropertyName("ownerTenantId")]
    int OwnerTenantId,
    [property: JsonPropertyName("parentTenantId")]
    int? ParentTenantId,
    [property: JsonPropertyName("partnerPrincipalId")]
    string? PartnerPrincipalId,
    [property: JsonPropertyName("principalId")]
    string? PrincipalId,
    [property: JsonPropertyName("slug")] string? Slug);
