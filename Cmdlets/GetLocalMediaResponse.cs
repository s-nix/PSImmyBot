using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "LocalMediaResponse")]
public class GetLocalMediaResponse : Cmdlet {
    [Parameter(Mandatory = true)]
    public int Id { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/media/local/{Id}?";

        LocalMediaResponse response = ImmyBotApiService.Get<LocalMediaResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
