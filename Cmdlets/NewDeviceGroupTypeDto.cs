using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "DeviceGroupTypeDto")]
public class NewDeviceGroupTypeDto : Cmdlet {
    [Parameter(Mandatory = false)] public string? Description { get; set; }
    [Parameter(Mandatory = true)] public required Guid DeviceGroupTypeId { get; set; }
    [Parameter(Mandatory = false)] public string? DisplayName { get; set; }
    [Parameter(Mandatory = true)] public required Guid ProviderTypeId { get; set; }
    [Parameter(Mandatory = true)] public required TargetScope TargetScope { get; set; }

    protected override void ProcessRecord() {
        DeviceGroupTypeDto outputObject = new(Description, DeviceGroupTypeId, DisplayName, ProviderTypeId, TargetScope);
        WriteObject(outputObject);
    }
}
