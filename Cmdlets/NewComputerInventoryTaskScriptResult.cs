using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ComputerInventoryTaskScriptResult")]
public class NewComputerInventoryTaskScriptResult : Cmdlet {
    [Parameter(Mandatory = true)] public required Computer Computer { get; set; }
    [Parameter(Mandatory = true)] public required int ComputerId { get; set; }
    [Parameter(Mandatory = false)] public string? InventoryKey { get; set; }
    [Parameter(Mandatory = false)] public object? LatestErrorResult { get; set; }
    [Parameter(Mandatory = true)] public required bool LatestResultIsError { get; set; }
    [Parameter(Mandatory = false)] public object? LatestSuccessResult { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset Timestamp { get; set; }

    protected override void ProcessRecord() {
        ComputerInventoryTaskScriptResult outputObject = new(Computer, ComputerId, InventoryKey, LatestErrorResult, LatestResultIsError, LatestSuccessResult, Timestamp);
        WriteObject(outputObject);
    }
}
