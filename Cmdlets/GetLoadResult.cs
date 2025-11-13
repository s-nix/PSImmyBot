using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "LoadResult")]
public class GetLoadResult : Cmdlet {
    [Parameter(Mandatory = false)]
    public DataSourceLoadOptions? LoadOptions { get; set; }

    [Parameter(Mandatory = false)]
    public DatabaseType? DatabaseType { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/scripts/dx?";
        endpoint += Globals.ConvertToQueryParameters(LoadOptions);
        endpoint += Globals.ConvertToQueryParameters(DatabaseType, "databaseType");

        LoadResult response = ImmyBotApiService.Get<LoadResult>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
