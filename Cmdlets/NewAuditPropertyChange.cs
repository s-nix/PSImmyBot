using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "AuditPropertyChange")]
public class NewAuditPropertyChange : Cmdlet {
    [Parameter(Mandatory = false)] public object? NewValue { get; set; }
    [Parameter(Mandatory = false)] public object? OldValue { get; set; }
    [Parameter(Mandatory = false)] public string? Property { get; set; }

    protected override void ProcessRecord() {
        AuditPropertyChange outputObject = new(NewValue, OldValue, Property);
        WriteObject(outputObject);
    }
}
