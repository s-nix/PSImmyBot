using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "DeviceUpdateFormDataResponse")]
public class NewDeviceUpdateFormDataResponse : Cmdlet {
    [Parameter(Mandatory = true)] public required int AgentId { get; set; }
    [Parameter(Mandatory = false)] public object? DeviceUpdateFormData { get; set; }

    protected override void ProcessRecord() {
        DeviceUpdateFormDataResponse outputObject = new(AgentId, DeviceUpdateFormData);
        WriteObject(outputObject);
    }
}
