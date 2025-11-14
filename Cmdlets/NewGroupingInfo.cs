using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GroupingInfo")]
public class NewGroupingInfo : Cmdlet {
    [Parameter(Mandatory = true)] public required bool Desc { get; set; }
    [Parameter(Mandatory = false)] public string? GroupInterval { get; set; }
    [Parameter(Mandatory = false)] public bool? IsExpanded { get; set; }
    [Parameter(Mandatory = false)] public string? Selector { get; set; }

    protected override void ProcessRecord() {
        GroupingInfo outputObject = new(Desc, GroupInterval, IsExpanded, Selector);
        WriteObject(outputObject);
    }
}
