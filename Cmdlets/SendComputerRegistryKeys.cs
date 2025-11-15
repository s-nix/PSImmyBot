using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "ComputerRegistryKeys")]
public class SendComputerRegistryKeys : Cmdlet
{
    [Parameter(Mandatory = true)]
    public int ComputerId { get; set; }

    [Parameter(Mandatory = true)]
    public required RegistryPayload PayloadBody { get; set; }

    protected override void ProcessRecord()
    {
        string endpoint = $"/api/v1/computers/{ComputerId}/registry/keys?";
        RegistryKeyDtoArrayOpResult response = ImmyBotApiService
            .Post<RegistryPayload, RegistryKeyDtoArrayOpResult>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody)
            .GetAwaiter()
            .GetResult();
        WriteObject(response);
    }
}
