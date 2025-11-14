using System.Management.Automation;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Disconnect", "Api")]
public class DisconnectApi : Cmdlet {
    protected override void ProcessRecord() {
        Globals.RemoveSavedApiToken();
    }
}
