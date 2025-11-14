using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "UpdateComputerPrimaryPersonRequestBody")]
public class SendUpdateComputerPrimaryPersonRequestBody : Cmdlet {
    [Parameter(Mandatory = true)]
    public int ComputerId { get; set; }


    [Parameter(Mandatory = true)] public required UpdateComputerPrimaryPersonRequestBody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/computers/{ComputerId}/update-primary-person?";

        GetPersonResponse response = ImmyBotApiService.Post<UpdateComputerPrimaryPersonRequestBody, GetPersonResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
