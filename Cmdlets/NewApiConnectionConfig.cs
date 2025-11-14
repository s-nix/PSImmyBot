using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ApiConnectionConfig")]
public class NewApiConnectionConfig : Cmdlet {


    protected override void ProcessRecord() {
        ApiConnectionConfig outputObject = new();
        WriteObject(outputObject);
    }
}
