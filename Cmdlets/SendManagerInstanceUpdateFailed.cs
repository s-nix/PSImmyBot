using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "ManagerInstanceUpdateFailed")]
public class SendManagerInstanceUpdateFailed : Cmdlet {


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/manager/instance-update-failed?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
