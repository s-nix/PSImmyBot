using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "GetClaimsResponse")]
public class GetGetClaimsResponse : Cmdlet {

    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/users/claims?";

        GetClaimsResponse response = ImmyBotApiService.Get<GetClaimsResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
