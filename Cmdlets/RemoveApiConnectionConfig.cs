using System.Management.Automation;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Remove", "ApiConnectionConfig")]
public class RemoveApiConnectionConfig : Cmdlet {
    protected override void ProcessRecord() {
        Globals.RemoveSavedApiConnectionConfig();
    }
}
