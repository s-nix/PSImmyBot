using System.Management.Automation;
using PSImmyBot.Models;
using RuntimeFieldHandle = PSImmyBot.Models.RuntimeFieldHandle;
using Type = PSImmyBot.Models.Type;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "FieldInfo")]
public class NewFieldInfo : Cmdlet {
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = true)] public required Type DeclaringType { get; set; }
    [Parameter(Mandatory = true)] public required Type ReflectedType { get; set; }
    [Parameter(Mandatory = true)] public required Module Module { get; set; }
    [Parameter(Mandatory = false)] public ICollection<CustomAttributeData>? CustomAttributes { get; set; }
    [Parameter(Mandatory = true)] public required bool IsCollectible { get; set; }
    [Parameter(Mandatory = true)] public required int MetadataToken { get; set; }
    [Parameter(Mandatory = true)] public required MemberTypes MemberType { get; set; }
    [Parameter(Mandatory = true)] public required FieldAttributes Attributes { get; set; }
    [Parameter(Mandatory = true)] public required Type FieldType { get; set; }
    [Parameter(Mandatory = true)] public required bool IsInitOnly { get; set; }
    [Parameter(Mandatory = true)] public required bool IsLiteral { get; set; }
    [Parameter(Mandatory = true)] public required bool IsNotSerialized { get; set; }
    [Parameter(Mandatory = true)] public required bool IsPinvokeImpl { get; set; }
    [Parameter(Mandatory = true)] public required bool IsSpecialName { get; set; }
    [Parameter(Mandatory = true)] public required bool IsStatic { get; set; }
    [Parameter(Mandatory = true)] public required bool IsAssembly { get; set; }
    [Parameter(Mandatory = true)] public required bool IsFamily { get; set; }
    [Parameter(Mandatory = true)] public required bool IsFamilyAndAssembly { get; set; }
    [Parameter(Mandatory = true)] public required bool IsFamilyOrAssembly { get; set; }
    [Parameter(Mandatory = true)] public required bool IsPrivate { get; set; }
    [Parameter(Mandatory = true)] public required bool IsPublic { get; set; }
    [Parameter(Mandatory = true)] public required bool IsSecurityCritical { get; set; }
    [Parameter(Mandatory = true)] public required bool IsSecuritySafeCritical { get; set; }
    [Parameter(Mandatory = true)] public required bool IsSecurityTransparent { get; set; }
    [Parameter(Mandatory = true)] public required RuntimeFieldHandle FieldHandle { get; set; }

    protected override void ProcessRecord() {
        FieldInfo outputObject = new(Name, DeclaringType, ReflectedType, Module, CustomAttributes, IsCollectible, MetadataToken, MemberType, Attributes, FieldType, IsInitOnly, IsLiteral, IsNotSerialized, IsPinvokeImpl, IsSpecialName, IsStatic, IsAssembly, IsFamily, IsFamilyAndAssembly, IsFamilyOrAssembly, IsPrivate, IsPublic, IsSecurityCritical, IsSecuritySafeCritical, IsSecurityTransparent, FieldHandle);
        WriteObject(outputObject);
    }
}
