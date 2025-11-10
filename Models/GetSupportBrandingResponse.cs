using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetSupportBrandingResponse(
    [property: JsonPropertyName("descriptionAlertMessage")]
    string? DescriptionAlertMessage,
    [property: JsonPropertyName("descriptionPlaceholderText")]
    string? DescriptionPlaceholderText,
    [property: JsonPropertyName("footerMessage")]
    string? FooterMessage,
    [property: JsonPropertyName("headerAlertMessage")]
    string? HeaderAlertMessage,
    [property: JsonPropertyName("providerId")]
    Guid ProviderId,
    [property: JsonPropertyName("sessionSupportButtonTitle")]
    string? SessionSupportButtonTitle,
    [property: JsonPropertyName("showConfirmationCheckbox")]
    bool ShowConfirmationCheckbox,
    [property: JsonPropertyName("showSessionSupportConfirmCheckbox")]
    bool ShowSessionSupportConfirmCheckbox,
    [property: JsonPropertyName("supportSidebarTitle")]
    string? SupportSidebarTitle);
