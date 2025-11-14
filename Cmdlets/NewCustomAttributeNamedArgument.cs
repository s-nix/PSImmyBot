using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "CustomAttributeNamedArgument")]
public class NewCustomAttributeNamedArgument : Cmdlet {
    [Parameter(Mandatory = true)] public required bool IsField { get; set; }
    [Parameter(Mandatory = true)] public required MemberInfo MemberInfo { get; set; }
    [Parameter(Mandatory = false)] public string? MemberName { get; set; }
    [Parameter(Mandatory = true)] public required CustomAttributeTypedArgument TypedValue { get; set; }

    protected override void ProcessRecord() {
        CustomAttributeNamedArgument outputObject = new(IsField, MemberInfo, MemberName, TypedValue);
        WriteObject(outputObject);
    }
}
