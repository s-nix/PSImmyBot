using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "UpdateLocalScriptRequestBody")]
public class NewUpdateLocalScriptRequestBody : Cmdlet {
    [Parameter(Mandatory = false)] public string? Action { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = true)] public required ScriptOutputType OutputType { get; set; }
    [Parameter(Mandatory = false)] public string? ScriptCacheName { get; set; }
    [Parameter(Mandatory = true)] public required ScriptCategory ScriptCategory { get; set; }
    [Parameter(Mandatory = true)] public required ScriptExecutionContext ScriptExecutionContext { get; set; }
    [Parameter(Mandatory = true)] public required ScriptLanguage ScriptLanguage { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType ScriptType { get; set; }
    [Parameter(Mandatory = false)] public ICollection<TenantScript>? Tenants { get; set; }
    [Parameter(Mandatory = false)] public int? Timeout { get; set; }

    protected override void ProcessRecord() {
        UpdateLocalScriptRequestBody outputObject = new(Action, Name, OutputType, ScriptCacheName, ScriptCategory, ScriptExecutionContext, ScriptLanguage, ScriptType, Tenants, Timeout);
        WriteObject(outputObject);
    }
}
