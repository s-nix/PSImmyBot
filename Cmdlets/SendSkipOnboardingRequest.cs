using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet("Send", "SkipOnboardingRequest")]
public class SendSkipOnboardingRequest : Cmdlet {

    [Parameter(Mandatory = true)] public required List<SkipOnboardingRequest> PayloadBody { get; set; }


    protected override void ProcessRecord() {
        string endpoint = "/api/v1/computers/skip-onboarding?";

        List<SkipOnboardingResponse> response = ImmyBotApiService.Post<List<SkipOnboardingRequest>, List<SkipOnboardingResponse>>(endpoint.TrimEnd('?').TrimEnd('&'), PayloadBody).GetAwaiter().GetResult();
        WriteObject(response);
    }

}
