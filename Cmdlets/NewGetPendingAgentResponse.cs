using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetPendingAgentResponse")]
public class NewGetPendingAgentResponse : Cmdlet {
    [Parameter(Mandatory = false)] public int? ComputerId { get; set; }
    [Parameter(Mandatory = false)] public string? ComputerName { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset DateAdded { get; set; }
    [Parameter(Mandatory = false)] public string? ExternalAgentId { get; set; }
    [Parameter(Mandatory = false)] public string? ExternalClientName { get; set; }
    [Parameter(Mandatory = true)] public required bool Failed { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public ICollection<GetAgentIdentificationFailureResponse>? IdentificationFailures { get; set; }
    [Parameter(Mandatory = true)] public required bool IsComputerDeleted { get; set; }
    [Parameter(Mandatory = true)] public required bool IsOnline { get; set; }
    [Parameter(Mandatory = false)] public string? Manufacturer { get; set; }
    [Parameter(Mandatory = false)] public string? OperatingSystemName { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? OsInstallDateUtc { get; set; }
    [Parameter(Mandatory = true)] public required int ProviderLinkId { get; set; }
    [Parameter(Mandatory = false)] public string? ProviderLinkName { get; set; }
    [Parameter(Mandatory = true)] public required bool RequireManualIdentification { get; set; }
    [Parameter(Mandatory = true)] public required bool RequiresManualResolution { get; set; }
    [Parameter(Mandatory = false)] public string? Serial { get; set; }

    protected override void ProcessRecord() {
        GetPendingAgentResponse outputObject = new(ComputerId, ComputerName, DateAdded, ExternalAgentId, ExternalClientName, Failed, Id, IdentificationFailures, IsComputerDeleted, IsOnline, Manufacturer, OperatingSystemName, OsInstallDateUtc, ProviderLinkId, ProviderLinkName, RequireManualIdentification, RequiresManualResolution, Serial);
        WriteObject(outputObject);
    }
}
