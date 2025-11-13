using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "RunImmyServiceResponseBody")]
public class NewRunImmyServiceResponseBody : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<RunImmyServiceResponseSession>? SessionsAlreadyInProgress { get; set; }
    [Parameter(Mandatory = false)] public ICollection<RunImmyServiceResponseSession>? SessionsStarted { get; set; }

    protected override void ProcessRecord() {
        RunImmyServiceResponseBody outputObject = new(SessionsAlreadyInProgress, SessionsStarted);
        WriteObject(outputObject);
    }
}
