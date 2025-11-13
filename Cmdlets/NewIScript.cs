using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "IScript")]
public class NewIScript : Cmdlet {
    [Parameter(Mandatory = false)] public string? Script { get; set; }
    [Parameter(Mandatory = true)] public required ScriptLanguage ScriptLanguage { get; set; }
    [Parameter(Mandatory = true)] public required int Timeout { get; set; }

    protected override void ProcessRecord() {
        IScript outputObject = new(Script, ScriptLanguage, Timeout);
        WriteObject(outputObject);
    }
}
