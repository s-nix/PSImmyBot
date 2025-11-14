using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ScriptActionAuditResult")]
public class NewScriptActionAuditResult : Cmdlet {
    [Parameter(Mandatory = true)] public required ScriptActionAudit Audit { get; set; }
    [Parameter(Mandatory = true)] public required int Total { get; set; }

    protected override void ProcessRecord() {
        ScriptActionAuditResult outputObject = new(Audit, Total);
        WriteObject(outputObject);
    }
}
