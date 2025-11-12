using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "GetLatestActionForComputersRequestBodyRequest")]
public class SendGetLatestActionForComputersRequestBodyRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required GetLatestActionForComputersRequestBody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/maintenance-actions/latest-action-for-computers?";

        List<GetMaintenanceActionResponse> response = ImmyBotApiService.Post<GetLatestActionForComputersRequestBody, List<GetMaintenanceActionResponse>>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
