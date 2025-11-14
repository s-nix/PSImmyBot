using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "Audit")]
public class GetAudit : Cmdlet {
    [Parameter(Mandatory = false)]
    public DataSourceLoadOptions? LoadOptions { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/audits/global/dx?";
        endpoint += Globals.ConvertToQueryParameters(LoadOptions);

        List<Audit> response = ImmyBotApiService.Get<List<Audit>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
