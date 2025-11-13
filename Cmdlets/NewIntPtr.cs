using System.Management.Automation;
using IntPtr = PSImmyBot.Models.IntPtr;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "IntPtr")]
public class NewIntPtr : Cmdlet {


    protected override void ProcessRecord() {
        IntPtr outputObject = new();
        WriteObject(outputObject);
    }
}
