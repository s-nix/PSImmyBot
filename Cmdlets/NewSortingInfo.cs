using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "SortingInfo")]
public class NewSortingInfo : Cmdlet {
    [Parameter(Mandatory = true)] public required bool Desc { get; set; }
    [Parameter(Mandatory = false)] public string? Selector { get; set; }

    protected override void ProcessRecord() {
        SortingInfo outputObject = new(Desc, Selector);
        WriteObject(outputObject);
    }
}
