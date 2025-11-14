using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetTenantSoftwareFromInventoryResponse")]
public class NewGetTenantSoftwareFromInventoryResponse : Cmdlet {
    [Parameter(Mandatory = false)] public string? AzureUserObjectId { get; set; }
    [Parameter(Mandatory = true)] public required int ComputerId { get; set; }
    [Parameter(Mandatory = false)] public string? ComputerName { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset DateDetectedUtc { get; set; }
    [Parameter(Mandatory = false)] public string? DisplayName { get; set; }
    [Parameter(Mandatory = true)] public required int GlobalSoftwareId { get; set; }
    [Parameter(Mandatory = false)] public string? GlobalSoftwareName { get; set; }
    [Parameter(Mandatory = false)] public string? GlobalSoftwareVersion { get; set; }
    [Parameter(Mandatory = false)] public int? PersonId { get; set; }
    [Parameter(Mandatory = false)] public string? PersonName { get; set; }
    [Parameter(Mandatory = true)] public required int TenantId { get; set; }

    protected override void ProcessRecord() {
        GetTenantSoftwareFromInventoryResponse outputObject = new(AzureUserObjectId, ComputerId, ComputerName, DateDetectedUtc, DisplayName, GlobalSoftwareId, GlobalSoftwareName, GlobalSoftwareVersion, PersonId, PersonName, TenantId);
        WriteObject(outputObject);
    }
}
