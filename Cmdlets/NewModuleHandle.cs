using System.Management.Automation;
using ModuleHandle = PSImmyBot.Models.ModuleHandle;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ModuleHandle")]
public class NewModuleHandle : Cmdlet {
    [Parameter(Mandatory = true)] public required int MdStreamVersion { get; set; }

    protected override void ProcessRecord() {
        ModuleHandle outputObject = new(MdStreamVersion);
        WriteObject(outputObject);
    }
}
