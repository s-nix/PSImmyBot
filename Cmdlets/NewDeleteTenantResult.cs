using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "DeleteTenantResult")]
public class NewDeleteTenantResult : Cmdlet {
    [Parameter(Mandatory = false)] public string? FailedReason { get; set; }
    [Parameter(Mandatory = true)] public required bool Success { get; set; }
    [Parameter(Mandatory = true)] public required int TenantId { get; set; }

    protected override void ProcessRecord() {
        DeleteTenantResult outputObject = new(FailedReason, Success, TenantId);
        WriteObject(outputObject);
    }
}
