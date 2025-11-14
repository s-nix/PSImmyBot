using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "AccessRequest")]
public class GetAccessRequest : Cmdlet {

    protected override void ProcessRecord() {
        string endpoint = "/api/v1/persons/requesting-access?";

        List<AccessRequestResponse> response = ImmyBotApiService.Get<List<AccessRequestResponse>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
