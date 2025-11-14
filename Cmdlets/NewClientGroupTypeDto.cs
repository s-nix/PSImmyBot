using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ClientGroupTypeDto")]
public class NewClientGroupTypeDto : Cmdlet {
    [Parameter(Mandatory = true)] public required Guid ClientGroupTypeId { get; set; }
    [Parameter(Mandatory = false)] public string? Description { get; set; }
    [Parameter(Mandatory = false)] public string? DisplayName { get; set; }
    [Parameter(Mandatory = true)] public required Guid ProviderTypeId { get; set; }

    protected override void ProcessRecord() {
        ClientGroupTypeDto outputObject = new(ClientGroupTypeId, Description, DisplayName, ProviderTypeId);
        WriteObject(outputObject);
    }
}
