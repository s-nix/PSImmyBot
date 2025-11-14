using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetPreferencesResponse")]
public class NewGetPreferencesResponse : Cmdlet {
    [Parameter(Mandatory = true)] public required ApplicationPreferences ApplicationPreferences { get; set; }
    [Parameter(Mandatory = true)] public required TenantPreferences TenantPreferences { get; set; }
    [Parameter(Mandatory = true)] public required UserPreferences UserPreferences { get; set; }

    protected override void ProcessRecord() {
        GetPreferencesResponse outputObject = new(ApplicationPreferences, TenantPreferences, UserPreferences);
        WriteObject(outputObject);
    }
}
