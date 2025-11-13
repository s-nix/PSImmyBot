using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "ComputerUserAffinities")]
public class GetComputerUserAffinities : Cmdlet {
    [Parameter(Mandatory = false)]
    public DataSourceLoadOptions? LoadOptions { get; set; }

    [Parameter(Mandatory = false)]
    public int? ComputerId { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/computers/user-affinities?";
        endpoint += Globals.ConvertToQueryParameters(LoadOptions);
        endpoint += Globals.ConvertToQueryParameters(ComputerId, "computerId");

        List<ComputerUserAffinityResponse> response = ImmyBotApiService.Get<List<ComputerUserAffinityResponse>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
