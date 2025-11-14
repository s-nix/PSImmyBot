using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "UserSilencedNotificationResponse")]
public class GetUserSilencedNotificationResponse : Cmdlet {

    protected override void ProcessRecord() {
        string endpoint = "/api/v1/notifications?";

        List<UserSilencedNotificationResponse> response = ImmyBotApiService.Get<List<UserSilencedNotificationResponse>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
