using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "GetExecutableUriParametersWithOnboardingOptions")]
public class SendGetExecutableUriParametersWithOnboardingOptions : Cmdlet {
    [Parameter(Mandatory = true)]
    public int Id { get; set; }


    [Parameter(Mandatory = true)] public required GetExecutableUriParametersWithOnboardingOptions PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/provider-links/{Id}/agents/executable-uri-with-onboarding?";

        string response = ImmyBotApiService.Post<GetExecutableUriParametersWithOnboardingOptions, string>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
