using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "RunImmybotComputerRequestBody")]
public class NewRunImmybotComputerRequestBody : Cmdlet {
    [Parameter(Mandatory = true)] public required int ComputerId { get; set; }
    [Parameter(Mandatory = false)] public IDictionary<string, IDictionary<string, DeploymentParameterValue>?>? MaintenanceTaskParameterValueOverrides { get; set; }
    protected override void ProcessRecord() {
        RunImmybotComputerRequestBody outputObject = new(ComputerId, MaintenanceTaskParameterValueOverrides);
        WriteObject(outputObject);
    }
}
