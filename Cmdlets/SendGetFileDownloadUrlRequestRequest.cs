using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "GetFileDownloadUrlRequestRequest")]
public class SendGetFileDownloadUrlRequestRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required GetFileDownloadUrlRequest PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/media/requestFileDownloadUrl?";

        string response = ImmyBotApiService.Post<GetFileDownloadUrlRequest, string>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
