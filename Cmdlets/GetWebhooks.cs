using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "Webhooks")]
public class GetWebhooks : Cmdlet {
    [Parameter(Mandatory = true)]
    public required string Id { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/webhooks/{Id}?";

        byte[] response = ImmyBotApiService.Get<byte[]>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
