using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetAuthResponse(
    [property: JsonPropertyName("addons")] ICollection<SubscriptionAddonDto>? Addons,
    [property: JsonPropertyName("backendRegAppId")]
    string? BackendRegAppId,
    [property: JsonPropertyName("canManageCrossTenantDeployments")]
    bool CanManageCrossTenantDeployments,
    [property: JsonPropertyName("claims")] ICollection<ClaimResponse>? Claims,
    [property: JsonPropertyName("currentReleaseReleaseChannel")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<ReleaseChannel>))]
    ReleaseChannel CurrentReleaseReleaseChannel,
    [property: JsonPropertyName("currentReleaseVersion")]
    SemanticVersion CurrentReleaseVersion,
    [property: JsonPropertyName("daysLeftInTrial")]
    int? DaysLeftInTrial,
    [property: JsonPropertyName("devInstanceDetails")]
    DevInstanceDetails DevInstanceDetails,
    [property: JsonPropertyName("displayName")]
    string? DisplayName,
    [property: JsonPropertyName("email")] string? Email,
    [property: JsonPropertyName("features")]
    ICollection<Feature>? Features,
    [property: JsonPropertyName("firstName")]
    string? FirstName,
    [property: JsonPropertyName("globalPublicMediaContainerName")]
    string? GlobalPublicMediaContainerName,
    [property: JsonPropertyName("globalSoftwareEndpoint")]
    string? GlobalSoftwareEndpoint,
    [property: JsonPropertyName("hasManagementAccess")]
    bool HasManagementAccess,
    [property: JsonPropertyName("immyProduct")]
    string? ImmyProduct,
    [property: JsonPropertyName("impersonating")]
    bool Impersonating,
    [property: JsonPropertyName("instanceReleaseChannel")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<ReleaseChannel>))]
    ReleaseChannel InstanceReleaseChannel,
    [property: JsonPropertyName("instanceUpdateHasFailed")]
    bool InstanceUpdateHasFailed,
    [property: JsonPropertyName("instanceUpdateSource")]
    string? InstanceUpdateSource,
    [property: JsonPropertyName("isAdmin")]
    bool IsAdmin,
    [property: JsonPropertyName("isImmense")]
    bool IsImmense,
    [property: JsonPropertyName("isImmySupportAccessEnabled")]
    bool IsImmySupportAccessEnabled,
    [property: JsonPropertyName("isInstanceRestarting")]
    bool IsInstanceRestarting,
    [property: JsonPropertyName("isInstanceUpdating")]
    bool IsInstanceUpdating,
    [property: JsonPropertyName("isMSP")] bool IsMsp,
    [property: JsonPropertyName("isSupportTechnician")]
    bool IsSupportTechnician,
    [property: JsonPropertyName("lastName")]
    string? LastName,
    [property: JsonPropertyName("localPublicMediaContainerName")]
    string? LocalPublicMediaContainerName,
    [property: JsonPropertyName("localSoftwareEndpoint")]
    string? LocalSoftwareEndpoint,
    [property: JsonPropertyName("maximumTrackableComputers")]
    int? MaximumTrackableComputers,
    [property: JsonPropertyName("maxRunningSessionCount")]
    int MaxRunningSessionCount,
    [property: JsonPropertyName("openAccessRequestCount")]
    int OpenAccessRequestCount,
    [property: JsonPropertyName("personId")]
    int? PersonId,
    [property: JsonPropertyName("planId")] string? PlanId,
    [property: JsonPropertyName("planPrice")]
    int? PlanPrice,
    [property: JsonPropertyName("planQuantity")]
    int? PlanQuantity,
    [property: JsonPropertyName("status")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<SubscriptionStatus>))]
    SubscriptionStatus Status,
    [property: JsonPropertyName("tenantId")]
    int TenantId,
    [property: JsonPropertyName("tenantName")]
    string? TenantName,
    [property: JsonPropertyName("trialEndUtc")]
    DateTimeOffset? TrialEndUtc,
    [property: JsonPropertyName("trialStartUtc")]
    DateTimeOffset? TrialStartUtc,
    [property: JsonPropertyName("updateAvailable")]
    bool UpdateAvailable,
    [property: JsonPropertyName("userId")] int UserId,
    [property: JsonPropertyName("userLevelAuthSelected")]
    bool UserLevelAuthSelected);
