using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "SystemDisableImmySupportAccessRequest")]
public class SendSystemDisableImmySupportAccessRequest : Cmdlet {


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/system/disable-immy-support-access?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
