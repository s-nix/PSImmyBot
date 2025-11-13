using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "SoftwareLocalUploadRequest")]
public class SendSoftwareLocalUploadRequest : Cmdlet {


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/software/local/upload?";

        SoftwareFileUploadData response = ImmyBotApiService.Post<SoftwareFileUploadData>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
