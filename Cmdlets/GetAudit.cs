using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "Audit")]
public class GetAudit : Cmdlet {
    [Parameter(Mandatory = false)]
    public DataSourceLoadOptions? loadOptions { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/audits/local/dx?";
        endpoint += Globals.ConvertToQueryParameters(loadOptions);

        List<Audit> response = ImmyBotApiService.Get<List<Audit>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
