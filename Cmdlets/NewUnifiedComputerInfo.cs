using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "UnifiedComputerInfo")]
public class NewUnifiedComputerInfo : Cmdlet {
    [Parameter(Mandatory = true)] public required int ComputerId { get; set; }
    [Parameter(Mandatory = false)] public string? ComputerName { get; set; }
    [Parameter(Mandatory = true)] public required bool IsOnline { get; set; }

    protected override void ProcessRecord() {
        UnifiedComputerInfo outputObject = new(ComputerId, ComputerName, IsOnline);
        WriteObject(outputObject);
    }
}
