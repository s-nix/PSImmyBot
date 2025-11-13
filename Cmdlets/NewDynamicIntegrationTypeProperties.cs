using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "DynamicIntegrationTypeProperties")]
public class NewDynamicIntegrationTypeProperties : Cmdlet {
    [Parameter(Mandatory = true)] public required DatabaseType DatabaseType { get; set; }
    [Parameter(Mandatory = false)] public string? DocsUrl { get; set; }
    [Parameter(Mandatory = true)] public required int LogoMediaId { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = true)] public required Guid ProviderTypeId { get; set; }
    [Parameter(Mandatory = false)] public IDictionary<string, object>? Secrets { get; set; }

    protected override void ProcessRecord() {
        DynamicIntegrationTypeProperties outputObject = new(DatabaseType, DocsUrl, LogoMediaId, Name, ProviderTypeId, Secrets);
        WriteObject(outputObject);
    }
}
