using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ScriptReference")]
public class NewScriptReference : Cmdlet {
    [Parameter(Mandatory = true)] public required DatabaseType DatabaseType { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = true)] public required ScriptReferenceType ScriptReferenceType { get; set; }
    [Parameter(Mandatory = true)] public required SemanticVersion SoftwareVersion { get; set; }

    protected override void ProcessRecord() {
        ScriptReference outputObject = new(DatabaseType, Id, Name, ScriptReferenceType, SoftwareVersion);
        WriteObject(outputObject);
    }
}
