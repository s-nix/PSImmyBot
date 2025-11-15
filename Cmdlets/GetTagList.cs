using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "TagList")]
public class GetTagList : Cmdlet
{
    [Parameter(Mandatory = false)]
    public string? Name { get; set; }

    [Parameter(Mandatory = false)]
    public bool? OrderByUpdatedDate { get; set; }

    [Parameter(Mandatory = false)]
    public int? PageSize { get; set; }


    protected override void ProcessRecord()
    {
        string endpoint = "/api/v1/tags?";
        endpoint += Globals.ConvertToQueryParameters(Name, "name");
        endpoint += Globals.ConvertToQueryParameters(OrderByUpdatedDate, "orderByUpdatedDate");
        endpoint += Globals.ConvertToQueryParameters(PageSize, "pageSize");

        List<Tag> response = ImmyBotApiService.Get<List<Tag>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
