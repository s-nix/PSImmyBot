using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "MediaSupportUploadRequest")]
public class SendMediaSupportUploadRequest : Cmdlet {


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/media/support/upload?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
