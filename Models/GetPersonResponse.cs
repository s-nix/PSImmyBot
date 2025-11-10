using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetPersonResponse(
    [property: JsonPropertyName("additionalComputers")]
    ICollection<GetComputerResponse>? AdditionalComputers,
    [property: JsonPropertyName("azurePrincipalId")]
    string? AzurePrincipalId,
    [property: JsonPropertyName("createdBy")]
    int? CreatedBy,
    [property: JsonPropertyName("createdDateUTC")]
    DateTimeOffset CreatedDateUtc,
    [property: JsonPropertyName("displayName")]
    string? DisplayName,
    [property: JsonPropertyName("emailAddress")]
    string? EmailAddress,
    [property: JsonPropertyName("firstName")]
    string? FirstName,
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("lastName")]
    string? LastName,
    [property: JsonPropertyName("primaryComputers")]
    ICollection<GetComputerResponse>? PrimaryComputers,
    [property: JsonPropertyName("tenantId")]
    int TenantId,
    [property: JsonPropertyName("updatedBy")]
    int? UpdatedBy,
    [property: JsonPropertyName("updatedDateUTC")]
    DateTimeOffset UpdatedDateUtc,
    [property: JsonPropertyName("user")] GetUserResponse User,
    [property: JsonPropertyName("userAffinities")]
    ICollection<GetUserAffinityResponse>? UserAffinities);
