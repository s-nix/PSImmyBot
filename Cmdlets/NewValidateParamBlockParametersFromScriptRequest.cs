using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ValidateParamBlockParametersFromScriptRequest")]
public class NewValidateParamBlockParametersFromScriptRequest : Cmdlet {
    [Parameter(Mandatory = false)] public int? ComputerId { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType DatabaseType { get; set; }
    [Parameter(Mandatory = true)] public required bool ForceRebind { get; set; }
    [Parameter(Mandatory = false)] public int? MaintenanceSessionId { get; set; }
    [Parameter(Mandatory = false)] public IDictionary<string, ParameterValue>? ParameterValues { get; set; }
    [Parameter(Mandatory = false)] public string? Script { get; set; }
    [Parameter(Mandatory = false)] public int? TenantId { get; set; }
    [Parameter(Mandatory = false)] public Guid? TerminalId { get; set; }
    [Parameter(Mandatory = true)] public required bool ValidateRequiresOverrideForOnboarding { get; set; }

    protected override void ProcessRecord() {
        ValidateParamBlockParametersFromScriptRequest outputObject = new(ComputerId, DatabaseType, ForceRebind, MaintenanceSessionId, ParameterValues, Script, TenantId, TerminalId, ValidateRequiresOverrideForOnboarding);
        WriteObject(outputObject);
    }
}
