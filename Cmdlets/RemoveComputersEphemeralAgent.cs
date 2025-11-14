using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Remove", "ComputersEphemeralAgent")]
public class RemoveComputersEphemeralAgent : Cmdlet {
    [Parameter(Mandatory = true)]
    public int ComputerId { get; set; }



    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/computers/{ComputerId}/ephemeral-agent?";

        ImmyBotApiService.Delete(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
