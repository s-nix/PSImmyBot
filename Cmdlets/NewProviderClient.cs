using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ProviderClient")]
public class NewProviderClient : Cmdlet {
    [Parameter(Mandatory = false)] public int? CreatedBy { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDate { get; set; }
    [Parameter(Mandatory = false)] public string? ExternalClientId { get; set; }
    [Parameter(Mandatory = false)] public string? ExternalClientName { get; set; }
    [Parameter(Mandatory = true)] public required bool HasCompletedInitialAgentSync { get; set; }
    [Parameter(Mandatory = false)] public object? InternalData { get; set; }
    [Parameter(Mandatory = true)] public required Tenant OwnerTenant { get; set; }
    [Parameter(Mandatory = false)] public ICollection<ProviderAgent>? ProviderAgents { get; set; }
    [Parameter(Mandatory = true)] public required ProviderLink ProviderLink { get; set; }
    [Parameter(Mandatory = true)] public required int ProviderLinkId { get; set; }
    [Parameter(Mandatory = false)] public string? Status { get; set; }
    [Parameter(Mandatory = false)] public int? TenantId { get; set; }
    [Parameter(Mandatory = false)] public ICollection<string>? Types { get; set; }
    [Parameter(Mandatory = false)] public int? UpdatedBy { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDate { get; set; }

    protected override void ProcessRecord() {
        ProviderClient outputObject = new(CreatedBy, CreatedDate, ExternalClientId, ExternalClientName, HasCompletedInitialAgentSync, InternalData, OwnerTenant, ProviderAgents, ProviderLink, ProviderLinkId, Status, TenantId, Types, UpdatedBy, UpdatedDate);
        WriteObject(outputObject);
    }
}
