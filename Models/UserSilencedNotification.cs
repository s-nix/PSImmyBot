using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record UserSilencedNotification(
    [property: JsonPropertyName("createdDate")]
    DateTimeOffset CreatedDate,
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("notificationObjectId")]
    string? NotificationObjectId,
    [property: JsonPropertyName("notificationType")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<NotificationType>))]
    NotificationType NotificationType,
    [property: JsonPropertyName("updatedDate")]
    DateTimeOffset UpdatedDate,
    [property: JsonPropertyName("user")] User User,
    [property: JsonPropertyName("userId")] int UserId);
