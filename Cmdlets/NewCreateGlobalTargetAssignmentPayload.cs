using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "CreateGlobalTargetAssignmentPayload")]
public class NewCreateGlobalTargetAssignmentPayload : Cmdlet {
    [Parameter(Mandatory = true)] public required DesiredSoftwareState DesiredSoftwareState { get; set; }
    [Parameter(Mandatory = true)] public required bool Excluded { get; set; }
    [Parameter(Mandatory = false)] public string? MaintenanceIdentifier { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceTaskMode MaintenanceTaskMode { get; set; }
    [Parameter(Mandatory = true)] public required MaintenanceType MaintenanceType { get; set; }
    [Parameter(Mandatory = true)] public required bool OnboardingOnly { get; set; }
    [Parameter(Mandatory = true)] public required SoftwareProviderType SoftwareProviderType { get; set; }
    [Parameter(Mandatory = true)] public required SemanticVersion SoftwareSemanticVersion { get; set; }
    [Parameter(Mandatory = false)] public string? Target { get; set; }
    [Parameter(Mandatory = true)] public required TargetCategory TargetCategory { get; set; }
    [Parameter(Mandatory = true)] public required TargetEnforcement TargetEnforcement { get; set; }
    [Parameter(Mandatory = true)] public required TargetGroupFilter TargetGroupFilter { get; set; }
    [Parameter(Mandatory = true)] public required TargetType TargetType { get; set; }
    [Parameter(Mandatory = false)] public IDictionary<string, DeploymentParameterValue>? TaskParameterValues { get; set; }

    protected override void ProcessRecord() {
        CreateGlobalTargetAssignmentPayload outputObject = new(DesiredSoftwareState, Excluded, MaintenanceIdentifier, MaintenanceTaskMode, MaintenanceType, OnboardingOnly, SoftwareProviderType, SoftwareSemanticVersion, Target, TargetCategory, TargetEnforcement, TargetGroupFilter, TargetType, TaskParameterValues);
        WriteObject(outputObject);
    }
}
