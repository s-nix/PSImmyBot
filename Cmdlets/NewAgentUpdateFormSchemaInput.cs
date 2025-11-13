using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "AgentUpdateFormSchemaInput")]
public class NewAgentUpdateFormSchemaInput : Cmdlet {
    [Parameter(Mandatory = false)] public object? Default { get; set; }
    [Parameter(Mandatory = false)] public string? Description { get; set; }
    [Parameter(Mandatory = false)] public Guid? DeviceGroupTypeId { get; set; }
    [Parameter(Mandatory = false)] public string? Label { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = true)] public required bool Required { get; set; }
    [Parameter(Mandatory = false)] public string? Type { get; set; }

    protected override void ProcessRecord() {
        AgentUpdateFormSchemaInput outputObject = new(Default, Description, DeviceGroupTypeId, Label, Name, Required, Type);
        WriteObject(outputObject);
    }
}
