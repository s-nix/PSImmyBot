using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ISubjectMetadata")]
public class NewISubjectMetadata : Cmdlet {
    [Parameter(Mandatory = false)] public string? Description { get; set; }
    [Parameter(Mandatory = false)] public string? DisplayName { get; set; }
    [Parameter(Mandatory = false)] public string? Id { get; set; }
    [Parameter(Mandatory = true)] public required bool IsMspOnly { get; set; }
    [Parameter(Mandatory = true)] public required bool IsResourceBased { get; set; }
    [Parameter(Mandatory = true)] public required bool IsSystemManaged { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = false)] public ICollection<IPermissionMetadata>? Permissions { get; set; }
    [Parameter(Mandatory = true)] public required int SortOrder { get; set; }

    protected override void ProcessRecord() {
        ISubjectMetadata outputObject = new(Description, DisplayName, Id, IsMspOnly, IsResourceBased, IsSystemManaged, Name, Permissions, SortOrder);
        WriteObject(outputObject);
    }
}
