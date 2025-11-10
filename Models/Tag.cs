using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record Tag(
    [property: JsonPropertyName("color")] string? Color,
    [property: JsonPropertyName("computers")]
    ICollection<Computer>? Computers,
    [property: JsonPropertyName("computerTags")]
    ICollection<ComputerTag>? ComputerTags,
    [property: JsonPropertyName("createdBy")]
    int? CreatedBy,
    [property: JsonPropertyName("createdByUser")]
    User CreatedByUser,
    [property: JsonPropertyName("createdDate")]
    DateTimeOffset CreatedDate,
    [property: JsonPropertyName("description")]
    string? Description,
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("name")] string? Name,
    [property: JsonPropertyName("persons")]
    ICollection<Person>? Persons,
    [property: JsonPropertyName("personTags")]
    ICollection<PersonTag>? PersonTags,
    [property: JsonPropertyName("tenantRelationships")]
    ICollection<TenantTagAuthorization>? TenantRelationships,
    [property: JsonPropertyName("tenants")]
    ICollection<Tenant>? Tenants,
    [property: JsonPropertyName("tenantTags")]
    ICollection<TenantTag>? TenantTags,
    [property: JsonPropertyName("updatedBy")]
    int? UpdatedBy,
    [property: JsonPropertyName("updatedByUser")]
    User UpdatedByUser,
    [property: JsonPropertyName("updatedDate")]
    DateTimeOffset UpdatedDate);
