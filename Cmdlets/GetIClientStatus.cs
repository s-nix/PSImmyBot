using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "IClientStatus")]
public class GetIClientStatus : Cmdlet {
    [Parameter(Mandatory = true)]
    public int Id { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/provider-links/{Id}/clients/statuses?";

        List<IClientStatus> response = ImmyBotApiService.Get<List<IClientStatus>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
