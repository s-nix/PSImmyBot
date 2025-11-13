using System.Management.Automation;
using PSImmyBot.Models;
using Type = PSImmyBot.Models.Type;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "EventInfo")]
public class NewEventInfo : Cmdlet {
    [Parameter(Mandatory = true)] public required MethodInfo AddMethod { get; set; }
    [Parameter(Mandatory = true)] public required EventAttributes Attributes { get; set; }
    [Parameter(Mandatory = false)] public ICollection<CustomAttributeData>? CustomAttributes { get; set; }
    [Parameter(Mandatory = true)] public required Type DeclaringType { get; set; }
    [Parameter(Mandatory = true)] public required Type EventHandlerType { get; set; }
    [Parameter(Mandatory = true)] public required bool IsCollectible { get; set; }
    [Parameter(Mandatory = true)] public required bool IsMulticast { get; set; }
    [Parameter(Mandatory = true)] public required bool IsSpecialName { get; set; }
    [Parameter(Mandatory = true)] public required MemberTypes MemberType { get; set; }
    [Parameter(Mandatory = true)] public required int MetadataToken { get; set; }
    [Parameter(Mandatory = true)] public required Module Module { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = true)] public required MethodInfo RaiseMethod { get; set; }
    [Parameter(Mandatory = true)] public required Type ReflectedType { get; set; }
    [Parameter(Mandatory = true)] public required MethodInfo RemoveMethod { get; set; }

    protected override void ProcessRecord() {
        EventInfo outputObject = new(AddMethod, Attributes, CustomAttributes, DeclaringType, EventHandlerType, IsCollectible, IsMulticast, IsSpecialName, MemberType, MetadataToken, Module, Name, RaiseMethod, ReflectedType, RemoveMethod);
        WriteObject(outputObject);
    }
}
