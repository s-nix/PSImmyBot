using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "ComputerDeviceUpdateFormData")]
public class GetComputerDeviceUpdateFormData : Cmdlet {
    [Parameter(Mandatory = true)]
    public int ComputerId { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/computers/{ComputerId}/device-update-form-data?";

        GetComputerDeviceUpdateFormDataResponse response = ImmyBotApiService.Get<GetComputerDeviceUpdateFormDataResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
