using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "NotificationsDx")]
public class GetNotificationsDx : Cmdlet
{
    [Parameter(Mandatory = false)]
    public DataSourceLoadOptions? LoadOptions { get; set; }


    protected override void ProcessRecord()
    {
        string endpoint = "/api/v1/notifications/dx?";
        endpoint += Globals.ConvertToQueryParameters(LoadOptions);

        List<Notification> response = ImmyBotApiService.Get<List<Notification>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
