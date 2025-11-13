using System.Management.Automation;
using IntPtr = PSImmyBot.Models.IntPtr;
using RuntimeFieldHandle = PSImmyBot.Models.RuntimeFieldHandle;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "RuntimeFieldHandle")]
public class NewRuntimeFieldHandle : Cmdlet {
    [Parameter(Mandatory = true)] public required IntPtr Value { get; set; }

    protected override void ProcessRecord() {
        RuntimeFieldHandle outputObject = new(Value);
        WriteObject(outputObject);
    }
}
