using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "CreateTagPayload")]
public class NewCreateTagPayload : Cmdlet {
    [Parameter(Mandatory = false)] public string? Color { get; set; }
    [Parameter(Mandatory = false)] public string? Description { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = false)] public ICollection<CreateTenantTagAuthorizationPayload>? TenantTagAuthorizations { get; set; }

    protected override void ProcessRecord() {
        CreateTagPayload outputObject = new(Color, Description, Name, TenantTagAuthorizations);
        WriteObject(outputObject);
    }
}
