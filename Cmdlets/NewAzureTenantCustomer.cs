using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "AzureTenantCustomer")]
public class NewAzureTenantCustomer : Cmdlet {
    [Parameter(Mandatory = false)] public string? DisplayName { get; set; }
    [Parameter(Mandatory = false)] public string? Domain { get; set; }
    [Parameter(Mandatory = false)] public ICollection<AzureGdapRelationshipDetails>? GdapRelationships { get; set; }
    [Parameter(Mandatory = false)] public string? TenantId { get; set; }

    protected override void ProcessRecord() {
        AzureTenantCustomer outputObject = new(DisplayName, Domain, GdapRelationships, TenantId);
        WriteObject(outputObject);
    }
}
