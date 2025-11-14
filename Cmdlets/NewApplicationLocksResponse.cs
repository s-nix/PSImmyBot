using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ApplicationLocksResponse")]
public class NewApplicationLocksResponse : Cmdlet {
    [Parameter(Mandatory = false)] public string? Key { get; set; }
    [Parameter(Mandatory = true)] public required ApplicationLockCallerInfo LockHolder { get; set; }
    [Parameter(Mandatory = false)] public ICollection<ApplicationLockCallerInfo>? LockWaiters { get; set; }

    protected override void ProcessRecord() {
        ApplicationLocksResponse outputObject = new(Key, LockHolder, LockWaiters);
        WriteObject(outputObject);
    }
}
