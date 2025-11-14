using System.Management.Automation;
using PSImmyBot.Models;
using ModuleHandle = PSImmyBot.Models.ModuleHandle;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "Module")]
public class NewModule : Cmdlet {
    [Parameter(Mandatory = true)] public required Assembly Assembly { get; set; }
    [Parameter(Mandatory = false)] public ICollection<CustomAttributeData>? CustomAttributes { get; set; }
    [Parameter(Mandatory = false)] public string? FullyQualifiedName { get; set; }
    [Parameter(Mandatory = true)] public required int MdStreamVersion { get; set; }
    [Parameter(Mandatory = true)] public required int MetadataToken { get; set; }
    [Parameter(Mandatory = true)] public required ModuleHandle ModuleHandle { get; set; }
    [Parameter(Mandatory = true)] public required Guid ModuleVersionId { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = false)] public string? ScopeName { get; set; }

    protected override void ProcessRecord() {
        Module outputObject = new(Assembly, CustomAttributes, FullyQualifiedName, MdStreamVersion, MetadataToken, ModuleHandle, ModuleVersionId, Name, ScopeName);
        WriteObject(outputObject);
    }
}
