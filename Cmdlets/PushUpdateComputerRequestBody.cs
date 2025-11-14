using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Push", "UpdateComputerRequestBody")]
public class PushUpdateComputerRequestBody : Cmdlet {
    [Parameter(Mandatory = true)]
    public int ComputerId { get; set; }


    [Parameter(Mandatory = true)] public required UpdateComputerRequestBody PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/computers/{ComputerId}?";

        GetComputerResponse response = ImmyBotApiService.Put<UpdateComputerRequestBody, GetComputerResponse>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
