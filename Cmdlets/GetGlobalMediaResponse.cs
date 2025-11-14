using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "GlobalMediaResponse")]
public class GetGlobalMediaResponse : Cmdlet {
    [Parameter(Mandatory = true)]
    public int Id { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/media/global/{Id}?";

        GlobalMediaResponse response = ImmyBotApiService.Get<GlobalMediaResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
