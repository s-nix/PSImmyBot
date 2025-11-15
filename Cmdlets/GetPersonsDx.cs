using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "PersonsDx")]
public class GetPersonsDx : Cmdlet
{
    [Parameter(Mandatory = false)]
    public DataSourceLoadOptions? LoadOptions { get; set; }

    [Parameter(Mandatory = false)]
    public int? TagId { get; set; }

    [Parameter(Mandatory = false)]
    public bool? IncludeTenant { get; set; }

    [Parameter(Mandatory = false)]
    public bool? IncludeUserData { get; set; }

    [Parameter(Mandatory = false)]
    public PersonType? PersonType { get; set; }


    protected override void ProcessRecord()
    {
        string endpoint = "/api/v1/persons/dx?";
        endpoint += Globals.ConvertToQueryParameters(LoadOptions);
        endpoint += Globals.ConvertToQueryParameters(TagId, "tagId");
        endpoint += Globals.ConvertToQueryParameters(IncludeTenant, "includeTenant");
        endpoint += Globals.ConvertToQueryParameters(IncludeUserData, "includeUserData");
        endpoint += Globals.ConvertToQueryParameters(PersonType, "personType");

        List<GetSimplePersonResponse> response = ImmyBotApiService.Get<List<GetSimplePersonResponse>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
