using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "SetPreflightScriptEnablementRequest")]
public class NewSetPreflightScriptEnablementRequest : Cmdlet {
    [Parameter(Mandatory = true)] public required DatabaseType DatabaseType { get; set; }
    [Parameter(Mandatory = true)] public required bool IsEnabled { get; set; }
    [Parameter(Mandatory = true)] public required int ScriptId { get; set; }

    protected override void ProcessRecord() {
        SetPreflightScriptEnablementRequest outputObject = new(DatabaseType, IsEnabled, ScriptId);
        WriteObject(outputObject);
    }
}
