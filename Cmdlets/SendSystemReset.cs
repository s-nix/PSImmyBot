using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "SystemReset")]
public class SendSystemReset : Cmdlet {


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/system/reset?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
