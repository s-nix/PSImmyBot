using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "AzureTenantAuthDetails")]
public class NewAzureTenantAuthDetails : Cmdlet {
    [Parameter(Mandatory = false)] public string? AzureTenantPrincipalId { get; set; }
    [Parameter(Mandatory = false)] public string? CustomAppRegAppId { get; set; }
    [Parameter(Mandatory = false)] public string? CustomAppRegSecret { get; set; }
    [Parameter(Mandatory = true)] public required AzurePermissionLevel2 SelectedPermissionLevel { get; set; }

    protected override void ProcessRecord() {
        AzureTenantAuthDetails outputObject = new(AzureTenantPrincipalId, CustomAppRegAppId, CustomAppRegSecret, SelectedPermissionLevel);
        WriteObject(outputObject);
    }
}
