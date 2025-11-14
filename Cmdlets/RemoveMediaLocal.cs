using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Remove", "MediaLocal")]
public class RemoveMediaLocal : Cmdlet {
    [Parameter(Mandatory = true)]
    public int Id { get; set; }



    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/media/local/{Id}?";

        ImmyBotApiService.Delete(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
