using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "SummaryInfo")]
public class NewSummaryInfo : Cmdlet {
    [Parameter(Mandatory = false)] public string? Selector { get; set; }
    [Parameter(Mandatory = false)] public string? SummaryType { get; set; }

    protected override void ProcessRecord() {
        SummaryInfo outputObject = new(Selector, SummaryType);
        WriteObject(outputObject);
    }
}
