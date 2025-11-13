using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetOnboardingComputerResponse")]
public class NewGetOnboardingComputerResponse : Cmdlet {
    [Parameter(Mandatory = false)] public string? ComputerName { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = true)] public required bool IsOnline { get; set; }
    [Parameter(Mandatory = true)] public required bool OnboardingFailed { get; set; }
    [Parameter(Mandatory = false)] public int? OnboardingSessionId { get; set; }
    [Parameter(Mandatory = true)] public required ComputerOnboardingStatus OnboardingStatus { get; set; }
    [Parameter(Mandatory = false)] public string? Serial { get; set; }
    [Parameter(Mandatory = false)] public string? TenantName { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDate { get; set; }

    protected override void ProcessRecord() {
        GetOnboardingComputerResponse outputObject = new(ComputerName, Id, IsOnline, OnboardingFailed, OnboardingSessionId, OnboardingStatus, Serial, TenantName, UpdatedDate);
        WriteObject(outputObject);
    }
}
