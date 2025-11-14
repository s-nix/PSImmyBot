using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ScriptSearchResult")]
public class NewScriptSearchResult : Cmdlet {
    [Parameter(Mandatory = false)] public string? Action { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = true)] public required bool Owned { get; set; }
    [Parameter(Mandatory = true)] public required ScriptCategory ScriptCategory { get; set; }
    [Parameter(Mandatory = true)] public required ScriptExecutionContext ScriptExecutionContext { get; set; }
    [Parameter(Mandatory = true)] public required ScriptLanguage ScriptLanguage { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType ScriptType { get; set; }

    protected override void ProcessRecord() {
        ScriptSearchResult outputObject = new(Action, Id, Name, Owned, ScriptCategory, ScriptExecutionContext, ScriptLanguage, ScriptType);
        WriteObject(outputObject);
    }
}
