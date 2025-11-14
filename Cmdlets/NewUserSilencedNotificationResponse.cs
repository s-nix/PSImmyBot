using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "UserSilencedNotificationResponse")]
public class NewUserSilencedNotificationResponse : Cmdlet {
    [Parameter(Mandatory = true)] public required DateTimeOffset DateSilencedUtc { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public string? NotificationObjectId { get; set; }
    [Parameter(Mandatory = true)] public required NotificationType NotificationType { get; set; }
    [Parameter(Mandatory = true)] public required int UserId { get; set; }

    protected override void ProcessRecord() {
        UserSilencedNotificationResponse outputObject = new(DateSilencedUtc, Id, NotificationObjectId, NotificationType, UserId);
        WriteObject(outputObject);
    }
}
