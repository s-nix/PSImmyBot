using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "IDeviceGroup")]
public class NewIDeviceGroup : Cmdlet {
    [Parameter(Mandatory = false)] public string? DeviceGroupDisplayName { get; set; }
    [Parameter(Mandatory = false)] public string? DeviceGroupId { get; set; }

    protected override void ProcessRecord() {
        IDeviceGroup outputObject = new(DeviceGroupDisplayName, DeviceGroupId);
        WriteObject(outputObject);
    }
}
