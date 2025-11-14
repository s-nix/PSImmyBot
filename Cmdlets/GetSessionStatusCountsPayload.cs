using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "SessionStatusCountsPayload")]
public class GetSessionStatusCountsPayload : Cmdlet {

    protected override void ProcessRecord() {
        string endpoint = "/api/v1/maintenance-sessions/status-counts?";

        SessionStatusCountsPayload response = ImmyBotApiService.Get<SessionStatusCountsPayload>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
