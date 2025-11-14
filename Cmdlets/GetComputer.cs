using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "Computer")]
public class GetComputer : Cmdlet {
    [Parameter(Mandatory = true)]
    public int ComputerId { get; set; }

    [Parameter(Mandatory = false)]
    public bool? IncludeSessions { get; set; }

    [Parameter(Mandatory = false)]
    public bool? IncludeAdditionalPersons { get; set; }

    [Parameter(Mandatory = false)]
    public bool? IncludePrimaryPerson { get; set; }

    [Parameter(Mandatory = false)]
    public bool? IncludeProviderAgents { get; set; }

    [Parameter(Mandatory = false)]
    public bool? IncludeProviderAgentsDeviceUpdateFormData { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/computers/{ComputerId}?";
        endpoint += Globals.ConvertToQueryParameters(IncludeSessions, "includeSessions");
        endpoint += Globals.ConvertToQueryParameters(IncludeAdditionalPersons, "includeAdditionalPersons");
        endpoint += Globals.ConvertToQueryParameters(IncludePrimaryPerson, "includePrimaryPerson");
        endpoint += Globals.ConvertToQueryParameters(IncludeProviderAgents, "includeProviderAgents");
        endpoint += Globals.ConvertToQueryParameters(IncludeProviderAgentsDeviceUpdateFormData, "includeProviderAgentsDeviceUpdateFormData");

        GetComputerResponse response = ImmyBotApiService.Get<GetComputerResponse>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
