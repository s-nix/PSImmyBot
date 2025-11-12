using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "GetOnboardingComputerResponse")]
public class GetGetOnboardingComputerResponse : Cmdlet {

    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/computers/onboarding?";

        List<GetOnboardingComputerResponse> response = ImmyBotApiService.Get<List<GetOnboardingComputerResponse>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
