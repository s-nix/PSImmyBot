using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "AzureErrorLogItem")]
public class GetAzureErrorLogItem : Cmdlet {
    [Parameter(Mandatory = false)]
    public DataSourceLoadOptions? LoadOptions { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/azure-errors/dx?";
        endpoint += Globals.ConvertToQueryParameters(LoadOptions);

        List<AzureErrorLogItem> response = ImmyBotApiService.Get<List<AzureErrorLogItem>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
