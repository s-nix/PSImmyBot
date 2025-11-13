using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "GetReleasesResponse")]
public class GetGetReleasesResponse : Cmdlet {

    protected override void ProcessRecord() {
        string endpoint = "/api/v1/system/releases?";

        GetReleasesResponse response = ImmyBotApiService.Get<GetReleasesResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
