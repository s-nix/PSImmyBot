using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetComputerDeviceUpdateFormDataResponse")]
public class NewGetComputerDeviceUpdateFormDataResponse : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<DeviceUpdateFormDataResponse>? Devices { get; set; }

    protected override void ProcessRecord() {
        GetComputerDeviceUpdateFormDataResponse outputObject = new(Devices);
        WriteObject(outputObject);
    }
}
