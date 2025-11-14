using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "CancelSessionsRequestBody")]
public class NewCancelSessionsRequestBody : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<int>? SessionIds { get; set; }

    protected override void ProcessRecord() {
        CancelSessionsRequestBody outputObject = new(SessionIds);
        WriteObject(outputObject);
    }
}
