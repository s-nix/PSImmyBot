using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "MediaGlobalUpload")]
public class SendMediaGlobalUpload : Cmdlet {


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/media/global/upload?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
