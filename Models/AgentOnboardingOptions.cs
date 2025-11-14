using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record AgentOnboardingOptions(
    [property: JsonPropertyName("additionalPersonIds")]
    ICollection<int>? AdditionalPersonIds,
    [property: JsonPropertyName("automaticallyOnboard")]
    bool AutomaticallyOnboard,
    [property: JsonPropertyName("isDevLab")]
    bool IsDevLab,
    [property: JsonPropertyName("onboardingCorrelationId")]
    string? OnboardingCorrelationId,
    [property: JsonPropertyName("onboardingSessionAutoConsentToReboots")]
    bool OnboardingSessionAutoConsentToReboots,
    [property: JsonPropertyName("onboardingSessionPromptTimeoutAction")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<PromptTimeoutAction>))]
    PromptTimeoutAction OnboardingSessionPromptTimeoutAction,
    [property: JsonPropertyName("onboardingSessionPromptTimeoutMinutes")]
    int OnboardingSessionPromptTimeoutMinutes,
    [property: JsonPropertyName("onboardingSessionRebootPreference")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<RebootPreference>))]
    RebootPreference OnboardingSessionRebootPreference,
    [property: JsonPropertyName("onboardingSessionSendFollowUpEmail")]
    bool OnboardingSessionSendFollowUpEmail,
    [property: JsonPropertyName("primaryPersonId")]
    int? PrimaryPersonId,
    [property: JsonPropertyName("tags")] ICollection<int>? Tags);
