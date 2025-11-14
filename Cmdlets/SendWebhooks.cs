using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "Webhooks")]
public class SendWebhooks : Cmdlet {
    [Parameter(Mandatory = true)]
    public required string Id { get; set; }



    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/webhooks/{Id}?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
