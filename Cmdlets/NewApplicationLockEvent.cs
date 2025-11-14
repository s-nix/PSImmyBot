using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ApplicationLockEvent")]
public class NewApplicationLockEvent : Cmdlet {
    [Parameter(Mandatory = false)] public string? Key { get; set; }
    [Parameter(Mandatory = true)] public required int EventType { get; set; }
    [Parameter(Mandatory = true)] public required string CallerInfo { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset EventTimestamp { get; set; }
    [Parameter(Mandatory = false)] public string? Reason { get; set; }

    protected override void ProcessRecord() {
        ApplicationLockEvent outputObject = new(Key, EventType, CallerInfo, EventTimestamp, Reason);
        WriteObject(outputObject);
    }
}
