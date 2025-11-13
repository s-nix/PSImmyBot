using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetPendingResponse")]
public class NewGetPendingResponse : Cmdlet {
    [Parameter(Mandatory = true)] public required int Count { get; set; }
    [Parameter(Mandatory = false)] public ICollection<GetPendingAgentResponse>? Results { get; set; }

    protected override void ProcessRecord() {
        GetPendingResponse outputObject = new(Count, Results);
        WriteObject(outputObject);
    }
}
