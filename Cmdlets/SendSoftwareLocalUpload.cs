using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "SoftwareLocalUpload")]
public class SendSoftwareLocalUpload : Cmdlet {


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/software/local/upload?";

        SoftwareFileUploadData response = ImmyBotApiService.Post<SoftwareFileUploadData>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
