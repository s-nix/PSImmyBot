using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "PreconsentCustomerTenantsRequest")]
public class NewPreconsentCustomerTenantsRequest : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<string>? CustomerPrincipalIds { get; set; }
    [Parameter(Mandatory = false)] public string? PartnerPrincipalId { get; set; }

    protected override void ProcessRecord() {
        PreconsentCustomerTenantsRequest outputObject = new(CustomerPrincipalIds, PartnerPrincipalId);
        WriteObject(outputObject);
    }
}
