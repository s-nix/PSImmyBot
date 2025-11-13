using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetSessionStatusCountsPayload")]
public class NewGetSessionStatusCountsPayload : Cmdlet {
    [Parameter(Mandatory = false)] public IDictionary<string, int>? Counts { get; set; }
    [Parameter(Mandatory = true)] public required double Total { get; set; }

    protected override void ProcessRecord() {
        GetSessionStatusCountsPayload outputObject = new(Counts, Total);
        WriteObject(outputObject);
    }
}
