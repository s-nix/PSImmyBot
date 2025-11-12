using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "SortingInfo")]
public class NewSortingInfo : Cmdlet {
    [Parameter(Mandatory = false)] public bool Desc { get; set; }
    [Parameter(Mandatory = false)] public string? Selector { get; set; }
    
    protected override void ProcessRecord() {
        SortingInfo sortingInfo = new(Desc, Selector);
        WriteObject(sortingInfo);
    }
}
