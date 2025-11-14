using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetProviderClientResponse")]
public class NewGetProviderClientResponse : Cmdlet {
    [Parameter(Mandatory = false)] public int? CreatedBy { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDateUtc { get; set; }
    [Parameter(Mandatory = false)] public string? ExternalClientId { get; set; }
    [Parameter(Mandatory = false)] public string? ExternalClientName { get; set; }
    [Parameter(Mandatory = false)] public object? InternalData { get; set; }
    [Parameter(Mandatory = false)] public int? LinkedToTenantId { get; set; }
    [Parameter(Mandatory = true)] public required GetProviderLinkResponse ProviderLink { get; set; }
    [Parameter(Mandatory = true)] public required int ProviderLinkId { get; set; }
    [Parameter(Mandatory = false)] public string? Status { get; set; }
    [Parameter(Mandatory = false)] public ICollection<string>? Types { get; set; }
    [Parameter(Mandatory = false)] public int? UpdatedBy { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDateUtc { get; set; }

    protected override void ProcessRecord() {
        GetProviderClientResponse outputObject = new(CreatedBy, CreatedDateUtc, ExternalClientId, ExternalClientName, InternalData, LinkedToTenantId, ProviderLink, ProviderLinkId, Status, Types, UpdatedBy, UpdatedDateUtc);
        WriteObject(outputObject);
    }
}
