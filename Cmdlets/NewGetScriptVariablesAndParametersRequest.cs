using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetScriptVariablesAndParametersRequest")]
public class NewGetScriptVariablesAndParametersRequest : Cmdlet {
    [Parameter(Mandatory = false)] public int? ComputerId { get; set; }
    [Parameter(Mandatory = true)] public required ScriptCategory ScriptCategory { get; set; }
    [Parameter(Mandatory = true)] public required ScriptExecutionContext ScriptExecutionContext { get; set; }
    [Parameter(Mandatory = false)] public int? SoftwareId { get; set; }
    [Parameter(Mandatory = true)] public required SoftwareType SoftwareType { get; set; }
    [Parameter(Mandatory = false)] public int? TaskId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType TaskType { get; set; }
    [Parameter(Mandatory = false)] public int? TenantId { get; set; }

    protected override void ProcessRecord() {
        GetScriptVariablesAndParametersRequest outputObject = new(ComputerId, ScriptCategory, ScriptExecutionContext, SoftwareId, SoftwareType, TaskId, TaskType, TenantId);
        WriteObject(outputObject);
    }
}
