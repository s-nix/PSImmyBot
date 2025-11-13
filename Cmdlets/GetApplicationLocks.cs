using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "ApplicationLocks")]
public class GetApplicationLocks : Cmdlet {

    protected override void ProcessRecord() {
        string endpoint = "/api/v1/application-locks?";

        List<ApplicationLocksResponse> response = ImmyBotApiService.Get<List<ApplicationLocksResponse>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
