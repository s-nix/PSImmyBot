using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ComputerInDeploymentDto")]
public class NewComputerInDeploymentDto : Cmdlet {
    [Parameter(Mandatory = true)] public required DatabaseType DatabaseType { get; set; }
    [Parameter(Mandatory = true)] public required int DeploymentId { get; set; }

    protected override void ProcessRecord() {
        ComputerInDeploymentDto outputObject = new(DatabaseType, DeploymentId);
        WriteObject(outputObject);
    }
}
