using System.Management.Automation;
using PSImmyBot.Models;
using Type = PSImmyBot.Models.Type;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "PropertyInfo")]
public class NewPropertyInfo : Cmdlet {
    [Parameter(Mandatory = true)] public required PropertyAttributes Attributes { get; set; }
    [Parameter(Mandatory = true)] public required bool CanRead { get; set; }
    [Parameter(Mandatory = true)] public required bool CanWrite { get; set; }
    [Parameter(Mandatory = false)] public ICollection<CustomAttributeData>? CustomAttributes { get; set; }
    [Parameter(Mandatory = true)] public required Type DeclaringType { get; set; }
    [Parameter(Mandatory = true)] public required MethodInfo GetMethod { get; set; }
    [Parameter(Mandatory = true)] public required bool IsCollectible { get; set; }
    [Parameter(Mandatory = true)] public required bool IsSpecialName { get; set; }
    [Parameter(Mandatory = true)] public required MemberTypes MemberType { get; set; }
    [Parameter(Mandatory = true)] public required int MetadataToken { get; set; }
    [Parameter(Mandatory = true)] public required Module Module { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = true)] public required Type PropertyType { get; set; }
    [Parameter(Mandatory = true)] public required Type ReflectedType { get; set; }
    [Parameter(Mandatory = true)] public required MethodInfo SetMethod { get; set; }

    protected override void ProcessRecord() {
        PropertyInfo outputObject = new(Attributes, CanRead, CanWrite, CustomAttributes, DeclaringType, GetMethod, IsCollectible, IsSpecialName, MemberType, MetadataToken, Module, Name, PropertyType, ReflectedType, SetMethod);
        WriteObject(outputObject);
    }
}
