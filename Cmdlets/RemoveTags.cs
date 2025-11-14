using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Remove", "Tags")]
public class RemoveTags : Cmdlet {
    [Parameter(Mandatory = true)]
    public int TagId { get; set; }



    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/tags/{TagId}?";

        ImmyBotApiService.Delete(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
