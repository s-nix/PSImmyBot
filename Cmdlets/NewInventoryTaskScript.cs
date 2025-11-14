using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "InventoryTaskScript")]
public class NewInventoryTaskScript : Cmdlet {
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDate { get; set; }
    [Parameter(Mandatory = true)] public required bool FromProvider { get; set; }
    [Parameter(Mandatory = false)] public string? InventoryKey { get; set; }
    [Parameter(Mandatory = true)] public required InventoryTask InventoryTask { get; set; }
    [Parameter(Mandatory = true)] public required int InventoryTaskId { get; set; }
    [Parameter(Mandatory = true)] public required bool SaveDebugStream { get; set; }
    [Parameter(Mandatory = true)] public required bool SaveInformationStream { get; set; }
    [Parameter(Mandatory = true)] public required bool SaveVerboseStream { get; set; }
    [Parameter(Mandatory = true)] public required bool SaveWarningStream { get; set; }
    [Parameter(Mandatory = true)] public required Script Script { get; set; }
    [Parameter(Mandatory = true)] public required int ScriptId { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDate { get; set; }

    protected override void ProcessRecord() {
        InventoryTaskScript outputObject = new(CreatedDate, FromProvider, InventoryKey, InventoryTask, InventoryTaskId, SaveDebugStream, SaveInformationStream, SaveVerboseStream, SaveWarningStream, Script, ScriptId, UpdatedDate);
        WriteObject(outputObject);
    }
}
