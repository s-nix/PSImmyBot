using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "IScriptDetailsBase")]
public class NewIScriptDetailsBase : Cmdlet {
    [Parameter(Mandatory = false)] public string? Action { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = true)] public required ScriptOutputType OutputType { get; set; }
    [Parameter(Mandatory = true)] public required ScriptCategory ScriptCategory { get; set; }
    [Parameter(Mandatory = true)] public required ScriptExecutionContext ScriptExecutionContext { get; set; }
    [Parameter(Mandatory = true)] public required ScriptLanguage ScriptLanguage { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType ScriptType { get; set; }
    [Parameter(Mandatory = false)] public int? Timeout { get; set; }

    protected override void ProcessRecord() {
        IScriptDetailsBase outputObject = new(Action, Name, OutputType, ScriptCategory, ScriptExecutionContext, ScriptLanguage, ScriptType, Timeout);
        WriteObject(outputObject);
    }
}
