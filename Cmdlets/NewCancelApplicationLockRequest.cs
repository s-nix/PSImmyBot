using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "CancelApplicationLockRequest")]
public class NewCancelApplicationLockRequest : Cmdlet {
    [Parameter(Mandatory = false)] public string? CancelReason { get; set; }
    [Parameter(Mandatory = false)] public string? Key { get; set; }

    protected override void ProcessRecord() {
        CancelApplicationLockRequest outputObject = new(CancelReason, Key);
        WriteObject(outputObject);
    }
}
