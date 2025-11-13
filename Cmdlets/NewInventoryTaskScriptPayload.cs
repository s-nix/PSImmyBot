using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "InventoryTaskScriptPayload")]
public class NewInventoryTaskScriptPayload : Cmdlet {
    [Parameter(Mandatory = false)] public string? InventoryKey { get; set; }
    [Parameter(Mandatory = true)] public required int InventoryTaskId { get; set; }
    [Parameter(Mandatory = true)] public required int ScriptId { get; set; }

    protected override void ProcessRecord() {
        InventoryTaskScriptPayload outputObject = new(InventoryKey, InventoryTaskId, ScriptId);
        WriteObject(outputObject);
    }
}
