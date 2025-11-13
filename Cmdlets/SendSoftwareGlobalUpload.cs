using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "SoftwareGlobalUpload")]
public class SendSoftwareGlobalUpload : Cmdlet {


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/software/global/upload?";

        SoftwareFileUploadData response = ImmyBotApiService.Post<SoftwareFileUploadData>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
