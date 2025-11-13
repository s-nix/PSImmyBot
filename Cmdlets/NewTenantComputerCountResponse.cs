using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "TenantComputerCountResponse")]
public class NewTenantComputerCountResponse : Cmdlet {
    [Parameter(Mandatory = true)] public required int ComputerCount { get; set; }
    [Parameter(Mandatory = true)] public required int TenantId { get; set; }

    protected override void ProcessRecord() {
        TenantComputerCountResponse outputObject = new(ComputerCount, TenantId);
        WriteObject(outputObject);
    }
}
