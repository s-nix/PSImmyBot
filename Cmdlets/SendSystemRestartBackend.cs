using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "SystemRestartBackend")]
public class SendSystemRestartBackend : Cmdlet {


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/system/restart-backend?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
