using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "CreatePersonPayload")]
public class NewCreatePersonPayload : Cmdlet {
    [Parameter(Mandatory = false)] public string? AzurePrincipalId { get; set; }
    [Parameter(Mandatory = false)] public string? EmailAddress { get; set; }
    [Parameter(Mandatory = false)] public string? FirstName { get; set; }
    [Parameter(Mandatory = false)] public string? LastName { get; set; }
    [Parameter(Mandatory = false)] public string? OnPremisesSecurityIdentifier { get; set; }
    [Parameter(Mandatory = true)] public required int TenantId { get; set; }

    protected override void ProcessRecord() {
        CreatePersonPayload outputObject = new(AzurePrincipalId, EmailAddress, FirstName, LastName, OnPremisesSecurityIdentifier, TenantId);
        WriteObject(outputObject);
    }
}
