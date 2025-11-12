using System.Management.Automation;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "ComputersSetToNeedsOnboardingRequest")]
public class SendComputersSetToNeedsOnboardingRequest : Cmdlet {
    [Parameter(Mandatory = true)]
    public int ComputerId { get; set; }



    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/computers/{ComputerId}/set-to-needs-onboarding?";

        ImmyBotApiService.Post(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
    }

}
