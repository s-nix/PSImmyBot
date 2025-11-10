using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record Person(
    [property: JsonPropertyName("accessRequests")]
    ICollection<AccessRequest>? AccessRequests,
    [property: JsonPropertyName("additionalComputers")]
    ICollection<ComputerPerson>? AdditionalComputers,
    [property: JsonPropertyName("azurePrincipalId")]
    string? AzurePrincipalId,
    [property: JsonPropertyName("createdBy")]
    int? CreatedBy,
    [property: JsonPropertyName("createdByUser")]
    User CreatedByUser,
    [property: JsonPropertyName("createdDate")]
    DateTimeOffset CreatedDate,
    [property: JsonPropertyName("detectedComputerSoftware")]
    ICollection<DetectedComputerSoftware>? DetectedComputerSoftware,
    [property: JsonPropertyName("displayName")]
    string? DisplayName,
    [property: JsonPropertyName("emailAddress")]
    string? EmailAddress,
    [property: JsonPropertyName("firstName")]
    string? FirstName,
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("lastName")]
    string? LastName,
    [property: JsonPropertyName("onPremisesSecurityIdentifier")]
    string? OnPremisesSecurityIdentifier,
    [property: JsonPropertyName("ownerTenant")]
    Tenant OwnerTenant,
    [property: JsonPropertyName("personSessions")]
    ICollection<MaintenanceSession>? PersonSessions,
    [property: JsonPropertyName("personTags")]
    ICollection<PersonTag>? PersonTags,
    [property: JsonPropertyName("primaryComputers")]
    ICollection<Computer>? PrimaryComputers,
    [property: JsonPropertyName("tags")] ICollection<Tag>? Tags,
    [property: JsonPropertyName("tenantId")]
    int TenantId,
    [property: JsonPropertyName("updatedBy")]
    int? UpdatedBy,
    [property: JsonPropertyName("updatedByUser")]
    User UpdatedByUser,
    [property: JsonPropertyName("updatedDate")]
    DateTimeOffset UpdatedDate,
    [property: JsonPropertyName("user")] User User,
    [property: JsonPropertyName("userAffinities")]
    ICollection<UserAffinity>? UserAffinities);
