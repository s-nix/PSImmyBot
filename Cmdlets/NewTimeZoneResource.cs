using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "TimeZoneResource")]
public class NewTimeZoneResource : Cmdlet {
    [Parameter(Mandatory = false)] public string? DisplayName { get; set; }
    [Parameter(Mandatory = false)] public string? Id { get; set; }

    protected override void ProcessRecord() {
        TimeZoneResource outputObject = new(DisplayName, Id);
        WriteObject(outputObject);
    }
}
