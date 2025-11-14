using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "StructLayoutAttribute")]
public class NewStructLayoutAttribute : Cmdlet {
    [Parameter(Mandatory = false)] public object? TypeId { get; set; }
    [Parameter(Mandatory = true)] public required LayoutKind Value { get; set; }

    protected override void ProcessRecord() {
        StructLayoutAttribute outputObject = new(TypeId, Value);
        WriteObject(outputObject);
    }
}
