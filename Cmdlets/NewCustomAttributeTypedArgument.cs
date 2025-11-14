using System.Management.Automation;
using PSImmyBot.Models;
using Type = PSImmyBot.Models.Type;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "CustomAttributeTypedArgument")]
public class NewCustomAttributeTypedArgument : Cmdlet {
    [Parameter(Mandatory = true)] public required Type ArgumentType { get; set; }
    [Parameter(Mandatory = false)] public object? Value { get; set; }

    protected override void ProcessRecord() {
        CustomAttributeTypedArgument outputObject = new(ArgumentType, Value);
        WriteObject(outputObject);
    }
}
