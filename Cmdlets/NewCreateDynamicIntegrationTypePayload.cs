using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "CreateDynamicIntegrationTypePayload")]
public class NewCreateDynamicIntegrationTypePayload : Cmdlet {
    [Parameter(Mandatory = false)] public string? DocsUrl { get; set; }
    [Parameter(Mandatory = true)] public required bool Enabled { get; set; }
    [Parameter(Mandatory = true)] public required Guid IntegrationTypeId { get; set; }
    [Parameter(Mandatory = true)] public required int LogoId { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = true)] public required int ScriptId { get; set; }
    [Parameter(Mandatory = true)] public required IntegrationTag Tag { get; set; }

    protected override void ProcessRecord() {
        CreateDynamicIntegrationTypePayload outputObject = new(DocsUrl, Enabled, IntegrationTypeId, LogoId, Name, ScriptId, Tag);
        WriteObject(outputObject);
    }
}
