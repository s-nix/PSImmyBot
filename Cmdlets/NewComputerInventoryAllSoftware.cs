using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ComputerInventoryAllSoftware")]
public class NewComputerInventoryAllSoftware : Cmdlet {
    [Parameter(Mandatory = false)] public string? Computer { get; set; }
    [Parameter(Mandatory = true)] public required int ComputerId { get; set; }
    [Parameter(Mandatory = false)] public string? SoftwareName { get; set; }
    [Parameter(Mandatory = false)] public string? SoftwareVersion { get; set; }
    [Parameter(Mandatory = false)] public string? Tenant { get; set; }
    [Parameter(Mandatory = true)] public required int TenantId { get; set; }

    protected override void ProcessRecord() {
        ComputerInventoryAllSoftware outputObject = new(Computer, ComputerId, SoftwareName, SoftwareVersion, Tenant, TenantId);
        WriteObject(outputObject);
    }
}
