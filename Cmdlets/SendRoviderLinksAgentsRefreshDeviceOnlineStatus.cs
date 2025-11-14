using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "RoviderLinksAgentsRefreshDeviceOnlineStatus")]
public class SendRoviderLinksAgentsRefreshDeviceOnlineStatus : Cmdlet {
    [Parameter(Mandatory = true)]
    public int Id { get; set; }

     [Parameter(Mandatory = true)]
    public int AgentId { get; set; }



    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/provider-links/{Id}/agents/{AgentId}/refresh-device-online-status?";

        bool response = ImmyBotApiService.Post<bool>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
