using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "LocalMedia")]
public class GetLocalMedia : Cmdlet
{
    [Parameter(Mandatory = false)]
    public DataSourceLoadOptions? LoadOptions { get; set; }

    [Parameter(Mandatory = false)]
    public MediaCategory? Category { get; set; }


    protected override void ProcessRecord()
    {
        string endpoint = "/api/v1/media/local?";
        endpoint += Globals.ConvertToQueryParameters(LoadOptions);
        endpoint += Globals.ConvertToQueryParameters(Category, "category");

        LoadResult response = ImmyBotApiService.Get<LoadResult>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
