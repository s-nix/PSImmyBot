using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetLocalScriptResponse")]
public class NewGetLocalScriptResponse : Cmdlet {
    [Parameter(Mandatory = false)] public string? Action { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDateUtc { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = true)] public required ScriptOutputType OutputType { get; set; }
    [Parameter(Mandatory = true)] public required bool Owned { get; set; }
    [Parameter(Mandatory = true)] public required ScriptCategory ScriptCategory { get; set; }
    [Parameter(Mandatory = true)] public required ScriptExecutionContext ScriptExecutionContext { get; set; }
    [Parameter(Mandatory = true)] public required ScriptLanguage ScriptLanguage { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType ScriptType { get; set; }
    [Parameter(Mandatory = false)] public int? Timeout { get; set; }
    [Parameter(Mandatory = false)] public string? UpdatedBy { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDateUtc { get; set; }

    protected override void ProcessRecord() {
        GetLocalScriptResponse outputObject = new(Action, CreatedDateUtc, Id, Name, OutputType, Owned, ScriptCategory, ScriptExecutionContext, ScriptLanguage, ScriptType, Timeout, UpdatedBy, UpdatedDateUtc);
        WriteObject(outputObject);
    }
}
