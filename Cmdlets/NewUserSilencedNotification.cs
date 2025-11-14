using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "UserSilencedNotification")]
public class NewUserSilencedNotification : Cmdlet {
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDate { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public string? NotificationObjectId { get; set; }
    [Parameter(Mandatory = true)] public required NotificationType NotificationType { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDate { get; set; }
    [Parameter(Mandatory = true)] public required User User { get; set; }
    [Parameter(Mandatory = true)] public required int UserId { get; set; }

    protected override void ProcessRecord() {
        UserSilencedNotification outputObject = new(CreatedDate, Id, NotificationObjectId, NotificationType, UpdatedDate, User, UserId);
        WriteObject(outputObject);
    }
}
