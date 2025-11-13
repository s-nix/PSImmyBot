using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "SystemEnableImmySupportAccess")]
public class SendSystemEnableImmySupportAccess : Cmdlet {


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/system/enable-immy-support-access?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
