using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "UpdateComputerAdditionalPersonsRequestBody")]
public class SendUpdateComputerAdditionalPersonsRequestBody : Cmdlet {
    [Parameter(Mandatory = true)]
    public int ComputerId { get; set; }


    [Parameter(Mandatory = true)] public required UpdateComputerAdditionalPersonsRequestBody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/computers/{ComputerId}/update-additional-persons?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
    }

}
