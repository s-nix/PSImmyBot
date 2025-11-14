using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Remove", "DynamicProviderTypesTestEnvironment")]
public class RemoveDynamicProviderTypesTestEnvironment : Cmdlet {
    [Parameter(Mandatory = true)]
    public required string TerminalId { get; set; }



    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/dynamic-provider-types/test-environment/{TerminalId}?";

        ImmyBotApiService.Delete(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
