using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ParameterType")]
public class NewParameterType : Cmdlet {
    [Parameter(Mandatory = false)] public object? ElementType { get; set; }
    [Parameter(Mandatory = false)] public object? EnumValues { get; set; }
    [Parameter(Mandatory = false)] public string? FullName { get; set; }
    [Parameter(Mandatory = true)] public required bool HasFlagAttribute { get; set; }
    [Parameter(Mandatory = true)] public required bool ImplementsDictionary { get; set; }
    [Parameter(Mandatory = true)] public required bool IsArray { get; set; }
    [Parameter(Mandatory = true)] public required bool IsEnum { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }

    protected override void ProcessRecord() {
        ParameterType outputObject = new(ElementType, EnumValues, FullName, HasFlagAttribute, ImplementsDictionary, IsArray, IsEnum, Name);
        WriteObject(outputObject);
    }
}
