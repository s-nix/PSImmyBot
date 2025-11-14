using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "AppRegistrationOptions")]
public class GetAppRegistrationOptions : Cmdlet {

    protected override void ProcessRecord() {
        string endpoint = "/api/v1/azure/app-registration-options?";

        List<AppRegistrationOption> response = ImmyBotApiService.Get<List<AppRegistrationOption>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
