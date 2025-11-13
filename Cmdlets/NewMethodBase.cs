using System.Management.Automation;
using PSImmyBot.Models;
using RuntimeMethodHandle = PSImmyBot.Models.RuntimeMethodHandle;
using Type = PSImmyBot.Models.Type;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "MethodBase")]
public class NewMethodBase : Cmdlet {
    [Parameter(Mandatory = true)] public required MethodAttributes Attributes { get; set; }
    [Parameter(Mandatory = true)] public required CallingConventions CallingConvention { get; set; }
    [Parameter(Mandatory = true)] public required bool ContainsGenericParameters { get; set; }
    [Parameter(Mandatory = false)] public ICollection<CustomAttributeData>? CustomAttributes { get; set; }
    [Parameter(Mandatory = true)] public required Type DeclaringType { get; set; }
    [Parameter(Mandatory = true)] public required bool IsAbstract { get; set; }
    [Parameter(Mandatory = true)] public required bool IsAssembly { get; set; }
    [Parameter(Mandatory = true)] public required bool IsCollectible { get; set; }
    [Parameter(Mandatory = true)] public required bool IsConstructedGenericMethod { get; set; }
    [Parameter(Mandatory = true)] public required bool IsConstructor { get; set; }
    [Parameter(Mandatory = true)] public required bool IsFamily { get; set; }
    [Parameter(Mandatory = true)] public required bool IsFamilyAndAssembly { get; set; }
    [Parameter(Mandatory = true)] public required bool IsFamilyOrAssembly { get; set; }
    [Parameter(Mandatory = true)] public required bool IsFinal { get; set; }
    [Parameter(Mandatory = true)] public required bool IsGenericMethod { get; set; }
    [Parameter(Mandatory = true)] public required bool IsGenericMethodDefinition { get; set; }
    [Parameter(Mandatory = true)] public required bool IsHideBySig { get; set; }
    [Parameter(Mandatory = true)] public required bool IsPrivate { get; set; }
    [Parameter(Mandatory = true)] public required bool IsPublic { get; set; }
    [Parameter(Mandatory = true)] public required bool IsSecurityCritical { get; set; }
    [Parameter(Mandatory = true)] public required bool IsSecuritySafeCritical { get; set; }
    [Parameter(Mandatory = true)] public required bool IsSecurityTransparent { get; set; }
    [Parameter(Mandatory = true)] public required bool IsSpecialName { get; set; }
    [Parameter(Mandatory = true)] public required bool IsStatic { get; set; }
    [Parameter(Mandatory = true)] public required bool IsVirtual { get; set; }
    [Parameter(Mandatory = true)] public required MemberTypes MemberType { get; set; }
    [Parameter(Mandatory = true)] public required int MetadataToken { get; set; }
    [Parameter(Mandatory = true)] public required RuntimeMethodHandle MethodHandle { get; set; }
    [Parameter(Mandatory = true)] public required MethodImplAttributes MethodImplementationFlags { get; set; }
    [Parameter(Mandatory = true)] public required Module Module { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = true)] public required Type ReflectedType { get; set; }

    protected override void ProcessRecord() {
        MethodBase outputObject = new(Attributes, CallingConvention, ContainsGenericParameters, CustomAttributes, DeclaringType, IsAbstract, IsAssembly, IsCollectible, IsConstructedGenericMethod, IsConstructor, IsFamily, IsFamilyAndAssembly, IsFamilyOrAssembly, IsFinal, IsGenericMethod, IsGenericMethodDefinition, IsHideBySig, IsPrivate, IsPublic, IsSecurityCritical, IsSecuritySafeCritical, IsSecurityTransparent, IsSpecialName, IsStatic, IsVirtual, MemberType, MetadataToken, MethodHandle, MethodImplementationFlags, Module, Name, ReflectedType);
        WriteObject(outputObject);
    }
}
