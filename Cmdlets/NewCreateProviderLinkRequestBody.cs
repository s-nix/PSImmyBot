using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "CreateProviderLinkRequestBody")]
public class NewCreateProviderLinkRequestBody : Cmdlet {
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = false)] public object? ProviderTypeFormData { get; set; }
    [Parameter(Mandatory = true)] public required Guid ProviderTypeId { get; set; }

    protected override void ProcessRecord() {
        CreateProviderLinkRequestBody outputObject = new(Name, ProviderTypeFormData, ProviderTypeId);
        WriteObject(outputObject);
    }
}
