using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "RunImmyServiceResponseSession")]
public class NewRunImmyServiceResponseSession : Cmdlet {
    [Parameter(Mandatory = false)] public int? ComputerId { get; set; }
    [Parameter(Mandatory = false)] public int? PersonId { get; set; }
    [Parameter(Mandatory = true)] public required int SessionId { get; set; }
    [Parameter(Mandatory = false)] public int? TenantId { get; set; }

    protected override void ProcessRecord() {
        RunImmyServiceResponseSession outputObject = new(ComputerId, PersonId, SessionId, TenantId);
        WriteObject(outputObject);
    }
}
