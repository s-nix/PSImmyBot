using System.Management.Automation;
using PSImmyBot.Models;
using Type = PSImmyBot.Models.Type;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ParameterInfo")]
public class NewParameterInfo : Cmdlet {
    [Parameter(Mandatory = true)] public required ParameterAttributes Attributes { get; set; }
    [Parameter(Mandatory = false)] public ICollection<CustomAttributeData>? CustomAttributes { get; set; }
    [Parameter(Mandatory = false)] public object? DefaultValue { get; set; }
    [Parameter(Mandatory = true)] public required bool HasDefaultValue { get; set; }
    [Parameter(Mandatory = true)] public required bool IsIn { get; set; }
    [Parameter(Mandatory = true)] public required bool IsLcid { get; set; }
    [Parameter(Mandatory = true)] public required bool IsOptional { get; set; }
    [Parameter(Mandatory = true)] public required bool IsOut { get; set; }
    [Parameter(Mandatory = true)] public required bool IsRetval { get; set; }
    [Parameter(Mandatory = true)] public required MemberInfo Member { get; set; }
    [Parameter(Mandatory = true)] public required int MetadataToken { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = true)] public required Type ParameterType { get; set; }
    [Parameter(Mandatory = true)] public required int Position { get; set; }
    [Parameter(Mandatory = false)] public object? RawDefaultValue { get; set; }

    protected override void ProcessRecord() {
        ParameterInfo outputObject = new(Attributes, CustomAttributes, DefaultValue, HasDefaultValue, IsIn, IsLcid, IsOptional, IsOut, IsRetval, Member, MetadataToken, Name, ParameterType, Position, RawDefaultValue);
        WriteObject(outputObject);
    }
}
