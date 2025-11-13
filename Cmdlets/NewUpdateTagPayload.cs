using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "UpdateTagPayload")]
public class NewUpdateTagPayload : Cmdlet {
    [Parameter(Mandatory = false)] public string? Color { get; set; }
    [Parameter(Mandatory = false)] public string? Description { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = false)] public ICollection<CreateTenantTagAuthorizationPayload>? TenantTagAuthorizations { get; set; }

    protected override void ProcessRecord() {
        UpdateTagPayload outputObject = new(Color, Description, Id, Name, TenantTagAuthorizations);
        WriteObject(outputObject);
    }
}
