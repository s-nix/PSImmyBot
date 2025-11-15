using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "ComputersDx")]
public class GetComputersDx : Cmdlet
{
    [Parameter(Mandatory = false)]
    public DataSourceLoadOptions? LoadOptions { get; set; }


    protected override void ProcessRecord()
    {
        string endpoint = "/api/v1/computers/dx?";
        endpoint += Globals.ConvertToQueryParameters(LoadOptions);

        LoadResult response = ImmyBotApiService.Get<LoadResult>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
