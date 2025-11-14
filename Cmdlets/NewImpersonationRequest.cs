using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ImpersonationRequest")]
public class NewImpersonationRequest : Cmdlet {
    [Parameter(Mandatory = true)] public required DateTimeOffset ExpiresAtUtc { get; set; }

    protected override void ProcessRecord() {
        ImpersonationRequest outputObject = new(ExpiresAtUtc);
        WriteObject(outputObject);
    }
}
