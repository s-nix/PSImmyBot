using System.Management.Automation;
using IntPtr = PSImmyBot.Models.IntPtr;
using RuntimeMethodHandle = PSImmyBot.Models.RuntimeMethodHandle;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "RuntimeMethodHandle")]
public class NewRuntimeMethodHandle : Cmdlet {
    [Parameter(Mandatory = true)] public required IntPtr Value { get; set; }

    protected override void ProcessRecord() {
        RuntimeMethodHandle outputObject = new(Value);
        WriteObject(outputObject);
    }
}
