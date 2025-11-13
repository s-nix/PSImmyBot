using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ScriptSyntaxCheckRequestBody")]
public class NewScriptSyntaxCheckRequestBody : Cmdlet {
    [Parameter(Mandatory = false)] public string? Script { get; set; }
    [Parameter(Mandatory = true)] public required ScriptLanguage ScriptLanguage { get; set; }

    protected override void ProcessRecord() {
        ScriptSyntaxCheckRequestBody outputObject = new(Script, ScriptLanguage);
        WriteObject(outputObject);
    }
}
