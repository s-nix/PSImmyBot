using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "UpdatePersonPayload")]
public class NewUpdatePersonPayload : Cmdlet {
    [Parameter(Mandatory = false)] public string? AzurePrincipalId { get; set; }
    [Parameter(Mandatory = false)] public string? EmailAddress { get; set; }
    [Parameter(Mandatory = false)] public string? FirstName { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public string? LastName { get; set; }
    [Parameter(Mandatory = true)] public required int TenantId { get; set; }

    protected override void ProcessRecord() {
        UpdatePersonPayload outputObject = new(AzurePrincipalId, EmailAddress, FirstName, Id, LastName, TenantId);
        WriteObject(outputObject);
    }
}
