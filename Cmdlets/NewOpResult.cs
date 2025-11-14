using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "OpResult")]
public class NewOpResult : Cmdlet {
    [Parameter(Mandatory = true)] public required DateTimeOffset DateCreatedUtc { get; set; }
    [Parameter(Mandatory = true)] public required bool IsSuccess { get; set; }
    [Parameter(Mandatory = false)] public string? Reason { get; set; }

    protected override void ProcessRecord() {
        OpResult outputObject = new(DateCreatedUtc, IsSuccess, Reason);
        WriteObject(outputObject);
    }
}
