using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "SkipOnboardingResponse")]
public class NewSkipOnboardingResponse : Cmdlet {
    [Parameter(Mandatory = true)] public required int ComputerId { get; set; }
    [Parameter(Mandatory = false)] public string? Message { get; set; }
    [Parameter(Mandatory = true)] public required bool Success { get; set; }

    protected override void ProcessRecord() {
        SkipOnboardingResponse outputObject = new(ComputerId, Message, Success);
        WriteObject(outputObject);
    }
}
