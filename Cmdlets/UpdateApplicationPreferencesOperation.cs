using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Update", "ApplicationPreferencesOperation")]
public class UpdateApplicationPreferencesOperation : Cmdlet {

    [Parameter(Mandatory = true)] public required List<ApplicationPreferencesOperation> PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/preferences/application?";

        ApplicationPreferences response = ImmyBotApiService.Patch<List<ApplicationPreferencesOperation>, ApplicationPreferences>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
