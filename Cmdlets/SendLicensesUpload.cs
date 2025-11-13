using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "LicensesUpload")]
public class SendLicensesUpload : Cmdlet {


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/licenses/upload?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
