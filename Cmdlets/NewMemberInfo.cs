using System.Management.Automation;
using PSImmyBot.Models;
using Type = PSImmyBot.Models.Type;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "MemberInfo")]
public class NewMemberInfo : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<CustomAttributeData>? CustomAttributes { get; set; }
    [Parameter(Mandatory = true)] public required Type DeclaringType { get; set; }
    [Parameter(Mandatory = true)] public required bool IsCollectible { get; set; }
    [Parameter(Mandatory = true)] public required MemberTypes MemberType { get; set; }
    [Parameter(Mandatory = true)] public required int MetadataToken { get; set; }
    [Parameter(Mandatory = true)] public required Module Module { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = true)] public required Type ReflectedType { get; set; }

    protected override void ProcessRecord() {
        MemberInfo outputObject = new(CustomAttributes, DeclaringType, IsCollectible, MemberType, MetadataToken, Module, Name, ReflectedType);
        WriteObject(outputObject);
    }
}
