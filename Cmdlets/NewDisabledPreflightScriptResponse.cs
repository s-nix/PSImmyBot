using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "DisabledPreflightScriptResponse")]
public class NewDisabledPreflightScriptResponse : Cmdlet {
    [Parameter(Mandatory = true)] public required DatabaseType DatabaseType { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = true)] public required int ScriptId { get; set; }

    protected override void ProcessRecord() {
        DisabledPreflightScriptResponse outputObject = new(DatabaseType, Id, ScriptId);
        WriteObject(outputObject);
    }
}
