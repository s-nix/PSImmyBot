using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "Int32OpResult")]
public class NewInt32OpResult : Cmdlet {
    [Parameter(Mandatory = true)] public required DateTimeOffset DateCreatedUtc { get; set; }
    [Parameter(Mandatory = true)] public required bool IsSuccess { get; set; }
    [Parameter(Mandatory = false)] public string? Reason { get; set; }
    [Parameter(Mandatory = true)] public required int Value { get; set; }

    protected override void ProcessRecord() {
        Int32OpResult outputObject = new(DateCreatedUtc, IsSuccess, Reason, Value);
        WriteObject(outputObject);
    }
}
