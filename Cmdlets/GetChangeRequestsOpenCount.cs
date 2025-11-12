using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "ChangeRequestsOpenCount")]
public class GetChangeRequestsOpenCount : Cmdlet {

    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/change-requests/open-count?";

        int response = ImmyBotApiService.Get<int>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
