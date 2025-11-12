using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "Tags")]
public class GetTags : Cmdlet {
    [Parameter(Mandatory = true)]
    public int TagId { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/tags/{TagId}?";

        byte[] response = ImmyBotApiService.Get<byte[]>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
