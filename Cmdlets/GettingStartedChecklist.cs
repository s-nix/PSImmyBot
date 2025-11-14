using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "GetGettingStartedChecklist")]
public class GetGettingStartedChecklist : Cmdlet {

    protected override void ProcessRecord() {
        string endpoint = "/api/v1/getting-started/checklist?";

        GettingStartedChecklist response = ImmyBotApiService.Get<GettingStartedChecklist>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
