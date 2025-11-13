using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "RunImmybotPersonRequestBody")]
public class NewRunImmybotPersonRequestBody : Cmdlet {
    [Parameter(Mandatory = false)] public IDictionary<string, IDictionary<string, DeploymentParameterValue>?>? MaintenanceTaskParameterValueOverrides { get; set; }
    [Parameter(Mandatory = true)] public required int PersonId { get; set; }

    protected override void ProcessRecord() {
        RunImmybotPersonRequestBody outputObject = new(MaintenanceTaskParameterValueOverrides, PersonId);
        WriteObject(outputObject);
    }
}
