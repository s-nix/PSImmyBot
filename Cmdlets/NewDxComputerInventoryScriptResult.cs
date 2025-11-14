using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "DxComputerInventoryScriptResult")]
public class NewDxComputerInventoryScriptResult : Cmdlet {
    [Parameter(Mandatory = true)] public required int ComputerId { get; set; }
    [Parameter(Mandatory = false)] public string? ComputerName { get; set; }
    [Parameter(Mandatory = false)] public string? InventoryKey { get; set; }
    [Parameter(Mandatory = false)] public object? LatestSuccessResult { get; set; }
    [Parameter(Mandatory = false)] public string? LatestSuccessResultJson { get; set; }
    [Parameter(Mandatory = true)] public required bool Success { get; set; }
    [Parameter(Mandatory = true)] public required int TenantId { get; set; }
    [Parameter(Mandatory = false)] public string? TenantName { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset TimestampUtc { get; set; }

    protected override void ProcessRecord() {
        DxComputerInventoryScriptResult outputObject = new(ComputerId, ComputerName, InventoryKey, LatestSuccessResult, LatestSuccessResultJson, Success, TenantId, TenantName, TimestampUtc);
        WriteObject(outputObject);
    }
}
