using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "AzureTenantLinkResponse")]
public class NewAzureTenantLinkResponse : Cmdlet {
    [Parameter(Mandatory = false)] public string? AzTenantId { get; set; }
    [Parameter(Mandatory = true)] public required AzureTenantResponse AzureTenant { get; set; }
    [Parameter(Mandatory = true)] public required int ImmyTenantId { get; set; }
    [Parameter(Mandatory = false)] public ICollection<AzureTenantLinkDomainFilter>? LimitToDomains { get; set; }
    [Parameter(Mandatory = true)] public required bool ShouldLimitDomains { get; set; }

    protected override void ProcessRecord() {
        AzureTenantLinkResponse outputObject = new(AzTenantId, AzureTenant, ImmyTenantId, LimitToDomains, ShouldLimitDomains);
        WriteObject(outputObject);
    }
}
