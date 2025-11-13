using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetFailedPendingAgentResponse")]
public class NewGetFailedPendingAgentResponse : Cmdlet {
    [Parameter(Mandatory = false)] public string? ComputerName { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset DateAdded { get; set; }
    [Parameter(Mandatory = false)] public string? DeviceId { get; set; }
    [Parameter(Mandatory = false)] public string? ExternalAgentId { get; set; }
    [Parameter(Mandatory = false)] public string? ExternalClientName { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public ICollection<GetAgentIdentificationFailureResponse>? IdentificationFailures { get; set; }
    [Parameter(Mandatory = true)] public required bool IsOnline { get; set; }
    [Parameter(Mandatory = false)] public string? OperatingSystemName { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? OsInstallDate { get; set; }
    [Parameter(Mandatory = false)] public DateTimeOffset? OsInstallDateUtc { get; set; }
    [Parameter(Mandatory = false)] public string? ProviderLinkName { get; set; }
    [Parameter(Mandatory = false)] public string? Serial { get; set; }

    protected override void ProcessRecord() {
        GetFailedPendingAgentResponse outputObject = new(ComputerName, DateAdded, DeviceId, ExternalAgentId, ExternalClientName, Id, IdentificationFailures, IsOnline, OperatingSystemName, OsInstallDate, OsInstallDateUtc, ProviderLinkName, Serial);
        WriteObject(outputObject);
    }
}
