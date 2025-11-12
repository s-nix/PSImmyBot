using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Commands;

[Cmdlet(VerbsCommon.New, "AccessRequest")]
public class NewAccessRequest : Cmdlet {
    [Parameter(Mandatory = true)] public required User AcknowledgedByUser { get; set; }
    [Parameter(Mandatory = false)] public int? AcknowledgedByUserId { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? DateAcknowledgedUtc { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset DateRequestedUtc { get; set; }
    [Parameter(Mandatory = true)] public required ExpirationTime ExpirationTime { get; set; }
    [Parameter(Mandatory = true)] public required bool Granted { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public bool? IsAdmin { get; set; }
    [Parameter(Mandatory = false)] public string? Message { get; set; }
    [Parameter(Mandatory = true)] public required Person Person { get; set; }
    [Parameter(Mandatory = true)] public required int PersonId { get; set; }

    protected override void ProcessRecord() {
        AccessRequest outputObject = new(AcknowledgedByUser, AcknowledgedByUserId, DateAcknowledgedUtc, DateRequestedUtc, ExpirationTime, Granted, Id, IsAdmin, Message, Person, PersonId);
        WriteObject(outputObject);
    }
}
