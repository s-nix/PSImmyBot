using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "UpdateTagPayload")]
public class SendUpdateTagPayload : Cmdlet {
    [Parameter(Mandatory = true)]
    public int TagId { get; set; }


    [Parameter(Mandatory = true)] public required UpdateTagPayload PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/tags/{TagId}?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
    }

}
