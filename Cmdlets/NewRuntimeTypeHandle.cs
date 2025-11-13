using System.Management.Automation;
using IntPtr = PSImmyBot.Models.IntPtr;
using RuntimeTypeHandle = PSImmyBot.Models.RuntimeTypeHandle;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "RuntimeTypeHandle")]
public class NewRuntimeTypeHandle : Cmdlet {
    [Parameter(Mandatory = true)] public required IntPtr Value { get; set; }

    protected override void ProcessRecord() {
        RuntimeTypeHandle outputObject = new(Value);
        WriteObject(outputObject);
    }
}
