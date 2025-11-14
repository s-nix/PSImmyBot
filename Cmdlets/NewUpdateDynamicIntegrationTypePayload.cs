using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "UpdateDynamicIntegrationTypePayload")]
public class NewUpdateDynamicIntegrationTypePayload : Cmdlet {
    [Parameter(Mandatory = false)] public string? DocsUrl { get; set; }
    [Parameter(Mandatory = true)] public required bool Enabled { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = true)] public required int LogoId { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = true)] public required int ScriptId { get; set; }
    [Parameter(Mandatory = true)] public required IntegrationTag Tag { get; set; }

    protected override void ProcessRecord() {
        UpdateDynamicIntegrationTypePayload outputObject = new(DocsUrl, Enabled, Id, LogoId, Name, ScriptId, Tag);
        WriteObject(outputObject);
    }
}
