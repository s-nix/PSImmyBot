using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "LicensesUploadRequest")]
public class SendLicensesUploadRequest : Cmdlet {


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/licenses/upload?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
