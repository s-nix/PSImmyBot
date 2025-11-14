using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "CreateTenantTagAuthorizationPayload")]
public class NewCreateTenantTagAuthorizationPayload : Cmdlet {
    [Parameter(Mandatory = true)] public required Relationship Relationship { get; set; }
    [Parameter(Mandatory = true)] public required int TenantId { get; set; }

    protected override void ProcessRecord() {
        CreateTenantTagAuthorizationPayload outputObject = new(Relationship, TenantId);
        WriteObject(outputObject);
    }
}
