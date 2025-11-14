using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "SkipOnboardingRequest")]
public class NewSkipOnboardingRequest : Cmdlet {
    [Parameter(Mandatory = true)] public required int ComputerId { get; set; }

    protected override void ProcessRecord() {
        SkipOnboardingRequest outputObject = new(ComputerId);
        WriteObject(outputObject);
    }
}
