using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "RunImmybotTenantRequestBody")]
public class NewRunImmybotTenantRequestBody : Cmdlet {
    [Parameter(Mandatory = false)] public IDictionary<string, IDictionary<string, DeploymentParameterValue>?>? MaintenanceTaskParameterValueOverrides { get; set; }
    [Parameter(Mandatory = true)] public required int TenantId { get; set; }

    protected override void ProcessRecord() {
        RunImmybotTenantRequestBody outputObject = new(MaintenanceTaskParameterValueOverrides, TenantId);
        WriteObject(outputObject);
    }
}
