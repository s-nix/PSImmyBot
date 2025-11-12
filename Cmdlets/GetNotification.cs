using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "Notification")]
public class GetNotification : Cmdlet {
    [Parameter(Mandatory = false)]
    public int? Limit { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/notifications/unacknowledged?";
        endpoint += Globals.ConvertToQueryParameters(Limit, "limit");

        List<Notification> response = ImmyBotApiService.Get<List<Notification>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
