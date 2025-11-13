using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "UpdateUserPayload")]
public class NewUpdateUserPayload : Cmdlet {
    [Parameter(Mandatory = true)] public required bool CanManageCrossTenantDeployments { get; set; }
    [Parameter(Mandatory = true)] public required bool HasManagementAccess { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = true)] public required bool IsAdmin { get; set; }
    [Parameter(Mandatory = true)] public required int TenantId { get; set; }

    protected override void ProcessRecord() {
        UpdateUserPayload outputObject = new(CanManageCrossTenantDeployments, HasManagementAccess, Id, IsAdmin, TenantId);
        WriteObject(outputObject);
    }
}
