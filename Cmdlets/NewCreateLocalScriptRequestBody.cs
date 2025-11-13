using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "CreateLocalScriptRequestBody")]
public class NewCreateLocalScriptRequestBody : Cmdlet {
    [Parameter(Mandatory = false)] public string? Action { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = true)] public required ScriptOutputType OutputType { get; set; }
    [Parameter(Mandatory = true)] public required ScriptCategory ScriptCategory { get; set; }
    [Parameter(Mandatory = true)] public required ScriptExecutionContext ScriptExecutionContext { get; set; }
    [Parameter(Mandatory = true)] public required ScriptLanguage ScriptLanguage { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType ScriptType { get; set; }
    [Parameter(Mandatory = false)] public ICollection<TenantScript>? Tenants { get; set; }
    [Parameter(Mandatory = false)] public int? Timeout { get; set; }

    protected override void ProcessRecord() {
        CreateLocalScriptRequestBody outputObject = new(Action, Name, OutputType, ScriptCategory, ScriptExecutionContext, ScriptLanguage, ScriptType, Tenants, Timeout);
        WriteObject(outputObject);
    }
}
