using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "InventoryTaskPayload")]
public class NewInventoryTaskPayload : Cmdlet {
    [Parameter(Mandatory = true)] public required InventoryTaskFrequency Frequency { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }

    protected override void ProcessRecord() {
        InventoryTaskPayload outputObject = new(Frequency, Name);
        WriteObject(outputObject);
    }
}
