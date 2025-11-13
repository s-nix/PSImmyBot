using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "BulkCreateTenantRequestBody")]
public class NewBulkCreateTenantRequestBody : Cmdlet {
    [Parameter(Mandatory = true)] public required int OwnerTenantId { get; set; }
    [Parameter(Mandatory = false)] public ICollection<BulkCreateTenantRequestBodyListItem>? Tenants { get; set; }

    protected override void ProcessRecord() {
        BulkCreateTenantRequestBody outputObject = new(OwnerTenantId, Tenants);
        WriteObject(outputObject);
    }
}
