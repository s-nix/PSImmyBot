using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "ManagerInstanceUpdating")]
public class SendManagerInstanceUpdating : Cmdlet {
    [Parameter(Mandatory = false)]
    public string? Source { get; set; }



    protected override void ProcessRecord() {
        string endpoint = "/api/v1/manager/instance-updating?";
        endpoint += Globals.ConvertToQueryParameters(Source, "source");

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
