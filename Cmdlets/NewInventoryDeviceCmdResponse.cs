using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "InventoryDeviceCmdResponse")]
public class NewInventoryDeviceCmdResponse : Cmdlet {
    [Parameter(Mandatory = false)] public string? FailureReason { get; set; }
    [Parameter(Mandatory = false)] public IDictionary<string, IDictionary<string, string>>? Output { get; set; }
    [Parameter(Mandatory = true)] public required bool Success { get; set; }

    protected override void ProcessRecord() {
        InventoryDeviceCmdResponse outputObject = new(FailureReason, Output, Success);
        WriteObject(outputObject);
    }
}
