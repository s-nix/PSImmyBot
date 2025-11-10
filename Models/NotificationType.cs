namespace PSImmyBot.Models;

/// <summary>
/// The string or integer value may be used. ProviderHealth = 1, AccessRequested = 2, LargeScriptOutput = 3, UnacknowledgedDeployments = 4, UpdateInstance = 5, ProviderAgentsRequiringManualDecision = 6, AzureTenantProblems = 7, AzureCustomerPreconsentFailed = 8, AzureMultiCustomerPreconsentFailed = 9, ChangeRequestCreatedOrUpdated = 10, ChangeRequestAcknowledged = 11, ProviderRecommendation = 12, FeatureUsageExceeded = 13, TenantDeletion = 14, ScheduleFailed = 15
/// </summary>

public enum NotificationType {

    ProviderHealth = 0,

    AccessRequested = 1,

    LargeScriptOutput = 2,

    UnacknowledgedDeployments = 3,

    UpdateInstance = 4,

    ProviderAgentsRequiringManualDecision = 5,

    AzureTenantProblems = 6,

    AzureCustomerPreconsentFailed = 7,

    AzureMultiCustomerPreconsentFailed = 8,

    ChangeRequestCreatedOrUpdated = 9,

    ChangeRequestAcknowledged = 10,

    ProviderRecommendation = 11,

    FeatureUsageExceeded = 12,

    TenantDeletion = 13,

    ScheduleFailed = 14,

}
