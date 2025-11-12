using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "MediaLocalUploadRequest")]
public class SendMediaLocalUploadRequest : Cmdlet {


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/media/local/upload?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
