using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "Preferences")]
public class GetPreferences : Cmdlet {

    protected override void ProcessRecord() {
        string endpoint = "/api/v1/preferences?";

        GetPreferencesResponse response = ImmyBotApiService.Get<GetPreferencesResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
