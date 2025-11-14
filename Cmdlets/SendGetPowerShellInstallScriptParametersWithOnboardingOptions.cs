using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "GetPowerShellInstallScriptParametersWithOnboardingOptions")]
public class SendGetPowerShellInstallScriptParametersWithOnboardingOptions : Cmdlet {
    [Parameter(Mandatory = true)]
    public int Id { get; set; }


    [Parameter(Mandatory = true)] public required GetPowerShellInstallScriptParametersWithOnboardingOptions PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/provider-links/{Id}/agents/powershell-install-script-with-onboarding?";

        IScript response = ImmyBotApiService.Post<GetPowerShellInstallScriptParametersWithOnboardingOptions, IScript>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
