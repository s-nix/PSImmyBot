using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "DuplicateScriptRequestBody")]
public class NewDuplicateScriptRequestBody : Cmdlet {
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType ScriptType { get; set; }

    protected override void ProcessRecord() {
        DuplicateScriptRequestBody outputObject = new(Id, ScriptType);
        WriteObject(outputObject);
    }
}
