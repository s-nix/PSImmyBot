using System.Management.Automation;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "ApiConnectionConfig")]
public class GetApiConnectionConfig : Cmdlet {
    protected override void ProcessRecord() {
        Models.ApiConnectionConfig config = Globals.GetApiConnectionConfig();
        WriteObject(config);
    }
}
