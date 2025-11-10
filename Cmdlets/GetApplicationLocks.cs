using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "ApplicationLocks")]
public class GetApplicationLocks : Cmdlet {
    protected override void ProcessRecord() {
        List<ApplicationLocksResponse> response = ImmyBotApiService.Get<List<ApplicationLocksResponse>>("/api/v1/application-locks").GetAwaiter().GetResult();
        WriteObject(response);
    }
}
