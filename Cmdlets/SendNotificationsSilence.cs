using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "NotificationsSilence")]
public class SendNotificationsSilence : Cmdlet {
    [Parameter(Mandatory = true)]
    public NotificationType Type { get; set; }

     [Parameter(Mandatory = false)]
    public string? ObjectId { get; set; }



    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/notifications/{Type}/silence?";
        endpoint += Globals.ConvertToQueryParameters(ObjectId, "objectId");

        UserSilencedNotificationResponse response = ImmyBotApiService.Post<UserSilencedNotificationResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
