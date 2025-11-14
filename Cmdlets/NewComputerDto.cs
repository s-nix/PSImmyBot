using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ComputerDto")]
public class NewComputerDto : Cmdlet {
    [Parameter(Mandatory = true)] public required int ComputerId { get; set; }
    [Parameter(Mandatory = false)] public ICollection<ComputerInDeploymentDto>? Deployments { get; set; }

    protected override void ProcessRecord() {
        ComputerDto outputObject = new(ComputerId, Deployments);
        WriteObject(outputObject);
    }
}
