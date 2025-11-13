using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "InventoryTaskScriptResource")]
public class NewInventoryTaskScriptResource : Cmdlet {
    [Parameter(Mandatory = true)] public required bool FromProvider { get; set; }
    [Parameter(Mandatory = false)] public string? InventoryKey { get; set; }
    [Parameter(Mandatory = true)] public required int ScriptId { get; set; }

    protected override void ProcessRecord() {
        InventoryTaskScriptResource outputObject = new(FromProvider, InventoryKey, ScriptId);
        WriteObject(outputObject);
    }
}
