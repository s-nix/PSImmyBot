using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "AzureTenantLink")]
public class NewAzureTenantLink : Cmdlet {
    [Parameter(Mandatory = false)] public string? AzTenantId { get; set; }
    [Parameter(Mandatory = true)] public required AzureTenant AzureTenant { get; set; }
    [Parameter(Mandatory = true)] public required int ImmyTenantId { get; set; }
    [Parameter(Mandatory = false)] public ICollection<AzureTenantLinkDomainFilter>? LimitToDomains { get; set; }
    [Parameter(Mandatory = true)] public required bool ShouldLimitDomains { get; set; }
    [Parameter(Mandatory = true)] public required Tenant Tenant { get; set; }

    protected override void ProcessRecord() {
        AzureTenantLink outputObject = new(AzTenantId, AzureTenant, ImmyTenantId, LimitToDomains, ShouldLimitDomains, Tenant);
        WriteObject(outputObject);
    }
}
