using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "GetRdpInfoResponse")]
public class GetGetRdpInfoResponse : Cmdlet {
    [Parameter(Mandatory = true)]
    public int ComputerId { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/dev-lab/{ComputerId}/rdp-info?";

        GetRdpInfoResponse response = ImmyBotApiService.Get<GetRdpInfoResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
