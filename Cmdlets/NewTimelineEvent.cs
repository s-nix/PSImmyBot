using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "TimelineEvent")]
public class NewTimelineEvent : Cmdlet {
    [Parameter(Mandatory = false)] public string? Data { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset DateUtc { get; set; }
    [Parameter(Mandatory = true)] public required TimelineEventType EventType { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public string? Identifier { get; set; }
    [Parameter(Mandatory = false)] public string? Message { get; set; }
    [Parameter(Mandatory = false)] public string? ObjectId { get; set; }
    [Parameter(Mandatory = true)] public required TimelineObjectType ObjectType { get; set; }

    protected override void ProcessRecord() {
        TimelineEvent outputObject = new(Data, DateUtc, EventType, Id, Identifier, Message, ObjectId, ObjectType);
        WriteObject(outputObject);
    }
}
