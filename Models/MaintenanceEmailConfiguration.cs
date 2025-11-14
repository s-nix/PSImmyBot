using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record MaintenanceEmailConfiguration(
    [property: JsonPropertyName("sendDetectionEmail")]
    bool SendDetectionEmail,
    [property: JsonPropertyName("sendDetectionEmailWhenAllActionsAreCompliant")]
    bool SendDetectionEmailWhenAllActionsAreCompliant,
    [property: JsonPropertyName("sendFollowUpEmail")]
    bool SendFollowUpEmail,
    [property: JsonPropertyName("sendFollowUpOnlyIfActionNeeded")]
    bool SendFollowUpOnlyIfActionNeeded,
    [property: JsonPropertyName("showMaintenanceActions")]
    bool ShowMaintenanceActions,
    [property: JsonPropertyName("showPostponeButton")]
    bool ShowPostponeButton,
    [property: JsonPropertyName("showRunNowButton")]
    bool ShowRunNowButton);
