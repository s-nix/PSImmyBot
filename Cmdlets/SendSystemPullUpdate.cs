using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "SystemPullUpdate")]
public class SendSystemPullUpdate : Cmdlet {


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/system/pull-update?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
