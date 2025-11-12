using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "GetAuthResponse")]
public class GetGetAuthResponse : Cmdlet {

    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/auth?";

        GetAuthResponse response = ImmyBotApiService.Get<GetAuthResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
