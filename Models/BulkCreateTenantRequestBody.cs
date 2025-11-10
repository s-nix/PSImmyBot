using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record BulkCreateTenantRequestBody(
    [property: JsonPropertyName("ownerTenantId")]
    int OwnerTenantId,
    [property: JsonPropertyName("tenants")]
    ICollection<BulkCreateTenantRequestBodyListItem>? Tenants);
