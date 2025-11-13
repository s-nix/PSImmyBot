using System.Management.Automation;
using PSImmyBot.Models;
using Type = PSImmyBot.Models.Type;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "Assembly")]
public class NewAssembly : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<TypeInfo>? DefinedTypes { get; set; }
    [Parameter(Mandatory = false)] public ICollection<Type>? ExportedTypes { get; set; }
    [Parameter(Mandatory = false)] public string? CodeBase { get; set; }
    [Parameter(Mandatory = true)] public required MethodInfo EntryPoint { get; set; }
    [Parameter(Mandatory = false)] public string? FullName { get; set; }
    [Parameter(Mandatory = false)] public string? ImageRuntimeVersion { get; set; }
    [Parameter(Mandatory = true)] public required bool IsDynamic { get; set; }
    [Parameter(Mandatory = false)] public string? Location { get; set; }
    [Parameter(Mandatory = true)] public required bool ReflectionOnly { get; set; }
    [Parameter(Mandatory = true)] public required bool IsCollectible { get; set; }
    [Parameter(Mandatory = true)] public required bool IsFullyTrusted { get; set; }
    [Parameter(Mandatory = false)] public ICollection<CustomAttributeData>? CustomAttributes { get; set; }
    [Parameter(Mandatory = false)] public string? EscapedCodeBase { get; set; }
    [Parameter(Mandatory = true)] public required Module ManifestModule { get; set; }
    [Parameter(Mandatory = false)] public ICollection<Module>? Modules { get; set; }
    [Parameter(Mandatory = true)] public required bool GlobalAssemblyCache { get; set; }
    [Parameter(Mandatory = true)] public required long HostContext { get; set; }
    [Parameter(Mandatory = true)] public required SecurityRuleSet SecurityRuleSet { get; set; }

    protected override void ProcessRecord() {
        Assembly outputObject = new(DefinedTypes, ExportedTypes, CodeBase, EntryPoint, FullName, ImageRuntimeVersion, IsDynamic, Location, ReflectionOnly, IsCollectible, IsFullyTrusted, CustomAttributes, EscapedCodeBase, ManifestModule, Modules, GlobalAssemblyCache, HostContext, SecurityRuleSet);
        WriteObject(outputObject);
    }
}
