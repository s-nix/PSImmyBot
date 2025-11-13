using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "GetBashInstallScriptParametersWithOnboardingOptionsRequest")]
public class SendGetBashInstallScriptParametersWithOnboardingOptionsRequest : Cmdlet {
    [Parameter(Mandatory = true)]
    public int Id { get; set; }


    [Parameter(Mandatory = true)] public required GetBashInstallScriptParametersWithOnboardingOptions PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/provider-links/{Id}/agents/bash-install-script-with-onboarding?";

        IScript response = ImmyBotApiService.Post<GetBashInstallScriptParametersWithOnboardingOptions, IScript>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
