using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ScriptActionAudit")]
public class NewScriptActionAudit : Cmdlet {
    [Parameter(Mandatory = true)] public required DateTimeOffset DateTimeUtc { get; set; }
    [Parameter(Mandatory = false)] public string? NewValue { get; set; }
    [Parameter(Mandatory = false)] public string? OldValue { get; set; }
    [Parameter(Mandatory = false)] public string? UserDisplayName { get; set; }

    protected override void ProcessRecord() {
        ScriptActionAudit outputObject = new(DateTimeUtc, NewValue, OldValue, UserDisplayName);
        WriteObject(outputObject);
    }
}
