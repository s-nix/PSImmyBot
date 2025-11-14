using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "StartEditorServicesRequest")]
public class NewStartEditorServicesRequest : Cmdlet {
    [Parameter(Mandatory = true)] public required ScriptCategory ScriptCategory { get; set; }
    [Parameter(Mandatory = true)] public required ScriptExecutionContext ScriptExecutionContext { get; set; }
    [Parameter(Mandatory = false)] public int? ScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType ScriptType { get; set; }
    [Parameter(Mandatory = true)] public required Guid TerminalId { get; set; }

    protected override void ProcessRecord() {
        StartEditorServicesRequest outputObject = new(ScriptCategory, ScriptExecutionContext, ScriptId, ScriptType, TerminalId);
        WriteObject(outputObject);
    }
}
