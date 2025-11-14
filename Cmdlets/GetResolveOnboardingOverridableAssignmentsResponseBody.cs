using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "ResolveOnboardingOverridableAssignmentsResponseBody")]
public class GetResolveOnboardingOverridableAssignmentsResponseBody : Cmdlet {
    [Parameter(Mandatory = true)]
    public int ComputerId { get; set; }


    protected override void ProcessRecord() {
        string endpoint = $"/api/v1/computers/{ComputerId}/resolve-onboarding-overridable-target-assignments?";

        ResolveOnboardingOverridableAssignmentsResponseBody response = ImmyBotApiService.Get<ResolveOnboardingOverridableAssignmentsResponseBody>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
