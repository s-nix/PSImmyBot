using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "AcknowledgeNotificationsRequest")]
public class NewAcknowledgeNotificationsRequest : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<Guid>? NotificationIds { get; set; }

    protected override void ProcessRecord() {
        AcknowledgeNotificationsRequest outputObject = new(NotificationIds);
        WriteObject(outputObject);
    }
}
