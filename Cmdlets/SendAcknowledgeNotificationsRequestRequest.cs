using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "AcknowledgeNotificationsRequestRequest")]
public class SendAcknowledgeNotificationsRequestRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required AcknowledgeNotificationsRequest PayloadBody { get; set; }
    
    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/notifications/acknowledge?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
    }
}
