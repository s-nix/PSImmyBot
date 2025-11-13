using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Update", "UserPreferencesOperation")]
public class UpdateUserPreferencesOperation : Cmdlet {

    [Parameter(Mandatory = true)] public required List<UserPreferencesOperation> PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/preferences/my?";

        UserPreferences response = ImmyBotApiService.Patch<List<UserPreferencesOperation>, UserPreferences>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
