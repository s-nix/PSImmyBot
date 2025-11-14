using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "RerunSessionsRequestBody")]
public class NewRerunSessionsRequestBody : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<int>? SessionIds { get; set; }

    protected override void ProcessRecord() {
        RerunSessionsRequestBody outputObject = new(SessionIds);
        WriteObject(outputObject);
    }
}
