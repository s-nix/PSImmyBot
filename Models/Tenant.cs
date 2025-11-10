using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record Tenant(
    [property: JsonPropertyName("active")] bool Active,
    [property: JsonPropertyName("azureTenantLink")]
    AzureTenantLink AzureTenantLink,
    [property: JsonPropertyName("brandings")]
    ICollection<Branding>? Brandings,
    [property: JsonPropertyName("computers")]
    ICollection<Computer>? Computers,
    [property: JsonPropertyName("createdBy")]
    int? CreatedBy,
    [property: JsonPropertyName("createdDate")]
    DateTimeOffset CreatedDate,
    [property: JsonPropertyName("detectedComputerSoftware")]
    ICollection<DetectedComputerSoftware>? DetectedComputerSoftware,
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("isMsp")] bool IsMsp,
    [property: JsonPropertyName("licenses")]
    ICollection<License>? Licenses,
    [property: JsonPropertyName("maintenanceSessions")]
    ICollection<MaintenanceSession>? MaintenanceSessions,
    [property: JsonPropertyName("maintenanceTasks")]
    ICollection<TenantMaintenanceTask>? MaintenanceTasks,
    [property: JsonPropertyName("markedForDeletionAtUtc")]
    DateTimeOffset? MarkedForDeletionAtUtc,
    [property: JsonPropertyName("media")] ICollection<TenantMedia>? Media,
    [property: JsonPropertyName("name")] string? Name,
    [property: JsonPropertyName("ownedProviderLinks")]
    ICollection<ProviderLink>? OwnedProviderLinks,
    [property: JsonPropertyName("ownedTenants")]
    ICollection<Tenant>? OwnedTenants,
    [property: JsonPropertyName("ownerTenant")]
    Tenant OwnerTenant,
    [property: JsonPropertyName("parentTenantId")]
    int? ParentTenantId,
    [property: JsonPropertyName("persons")]
    ICollection<Person>? Persons,
    [property: JsonPropertyName("providerClients")]
    ICollection<ProviderClient>? ProviderClients,
    [property: JsonPropertyName("schedules")]
    ICollection<Schedule>? Schedules,
    [property: JsonPropertyName("scripts")]
    ICollection<TenantScript>? Scripts,
    [property: JsonPropertyName("slug")] string? Slug,
    [property: JsonPropertyName("smtpConfig")]
    SmtpConfig SmtpConfig,
    [property: JsonPropertyName("tags")] ICollection<Tag>? Tags,
    [property: JsonPropertyName("tenantId")]
    int? TenantId,
    [property: JsonPropertyName("tenantPreferences")]
    TenantPreferences TenantPreferences,
    [property: JsonPropertyName("tenantSoftware")]
    ICollection<TenantSoftware>? TenantSoftware,
    [property: JsonPropertyName("tenantTagAuthorizations")]
    ICollection<TenantTagAuthorization>? TenantTagAuthorizations,
    [property: JsonPropertyName("tenantTags")]
    ICollection<TenantTag>? TenantTags,
    [property: JsonPropertyName("updatedBy")]
    int? UpdatedBy,
    [property: JsonPropertyName("updatedDate")]
    DateTimeOffset UpdatedDate,
    [property: JsonPropertyName("users")] ICollection<User>? Users);
