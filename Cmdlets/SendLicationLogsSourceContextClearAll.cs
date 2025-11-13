using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "LicationLogsSourceContextClearAll")]
public class SendLicationLogsSourceContextClearAll : Cmdlet {


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/application-logs/source-context/clear-all?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
