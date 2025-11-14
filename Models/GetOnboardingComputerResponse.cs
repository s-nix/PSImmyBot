using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetOnboardingComputerResponse(
    [property: JsonPropertyName("computerName")]
    string? ComputerName, [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("isOnline")]
    bool IsOnline,
    [property: JsonPropertyName("onboardingFailed")]
    bool OnboardingFailed,
    [property: JsonPropertyName("onboardingSessionId")]
    int? OnboardingSessionId,
    [property: JsonPropertyName("onboardingStatus")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<ComputerOnboardingStatus>))]
    ComputerOnboardingStatus OnboardingStatus,
    [property: JsonPropertyName("serial")] string? Serial,
    [property: JsonPropertyName("tenantName")]
    string? TenantName,
    [property: JsonPropertyName("updatedDate")]
    DateTimeOffset UpdatedDate);
