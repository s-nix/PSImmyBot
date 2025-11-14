using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "GetProvisioningPackageUriParametersWithOnboardingOptions")]
public class SendGetProvisioningPackageUriParametersWithOnboardingOptions : Cmdlet {
    [Parameter(Mandatory = true)]
    public int Id { get; set; }


    [Parameter(Mandatory = true)] public required GetProvisioningPackageUriParametersWithOnboardingOptions PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/provider-links/{Id}/agents/provisioning-package-uri-with-onboarding?";

        string response = ImmyBotApiService.Post<GetProvisioningPackageUriParametersWithOnboardingOptions, string>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
