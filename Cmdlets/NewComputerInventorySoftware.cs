using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ComputerInventorySoftware")]
public class NewComputerInventorySoftware : Cmdlet {
    [Parameter(Mandatory = true)] public required int Computers { get; set; }
    [Parameter(Mandatory = false)] public string? DisplayName { get; set; }
    [Parameter(Mandatory = false)] public string? DisplayVersion { get; set; }
    [Parameter(Mandatory = false)] public Guid? UpgradeCode { get; set; }

    protected override void ProcessRecord() {
        ComputerInventorySoftware outputObject = new(Computers, DisplayName, DisplayVersion, UpgradeCode);
        WriteObject(outputObject);
    }
}
