using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ApplicationLockEventEventStream")]
public class NewApplicationLockEventEventStream : Cmdlet {


    protected override void ProcessRecord() {
        ApplicationLockEventEventStream outputObject = new();
        WriteObject(outputObject);
    }
}
