using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "SourceContexts")]
public class GetSourceContexts : Cmdlet {

    protected override void ProcessRecord() {
        string endpoint = "/api/v1/application-logs/source-contexts?";

        GetSourceContextsResponse response = ImmyBotApiService.Get<GetSourceContextsResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
