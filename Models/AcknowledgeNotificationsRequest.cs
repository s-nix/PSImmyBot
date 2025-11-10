using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record AcknowledgeNotificationsRequest(
    [property: JsonPropertyName("notificationIds")]
    ICollection<Guid>? NotificationIds);
