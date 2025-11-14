using System.Management.Automation;
using PSImmyBot.Models;
using Type = PSImmyBot.Models.Type;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "CustomAttributeData")]
public class NewCustomAttributeData : Cmdlet {
    [Parameter(Mandatory = true)] public required Type AttributeType { get; set; }
    [Parameter(Mandatory = true)] public required ConstructorInfo Constructor { get; set; }
    [Parameter(Mandatory = false)] public ICollection<CustomAttributeTypedArgument>? ConstructorArguments { get; set; }
    [Parameter(Mandatory = false)] public ICollection<CustomAttributeNamedArgument>? NamedArguments { get; set; }

    protected override void ProcessRecord() {
        CustomAttributeData outputObject = new(AttributeType, Constructor, ConstructorArguments, NamedArguments);
        WriteObject(outputObject);
    }
}
