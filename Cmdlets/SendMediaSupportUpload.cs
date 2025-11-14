using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "MediaSupportUpload")]
public class SendMediaSupportUpload : Cmdlet {


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/media/support/upload?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
