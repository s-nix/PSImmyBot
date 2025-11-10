using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetTenantResponse(
    [property: JsonPropertyName("active")] bool Active,
    [property: JsonPropertyName("azureTenantLink")]
    AzureTenantLinkResponse AzureTenantLink,
    [property: JsonPropertyName("createdBy")]
    int? CreatedBy,
    [property: JsonPropertyName("createdDateUTC")]
    DateTimeOffset CreatedDateUtc,
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("isMsp")] bool IsMsp,
    [property: JsonPropertyName("markedForDeletionAtUtc")]
    DateTimeOffset? MarkedForDeletionAtUtc,
    [property: JsonPropertyName("name")] string? Name,
    [property: JsonPropertyName("ownerTenantId")]
    int? OwnerTenantId,
    [property: JsonPropertyName("parentTenantId")]
    int? ParentTenantId,
    [property: JsonPropertyName("slug")] string? Slug,
    [property: JsonPropertyName("tenantTagIds")]
    ICollection<int>? TenantTagIds,
    [property: JsonPropertyName("tenantTagNames")]
    ICollection<string>? TenantTagNames,
    [property: JsonPropertyName("updatedBy")]
    int? UpdatedBy,
    [property: JsonPropertyName("updatedDateUTC")]
    DateTimeOffset UpdatedDateUtc);
