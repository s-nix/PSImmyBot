using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "DynamicIntegrationType")]
public class NewDynamicIntegrationType : Cmdlet {
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDate { get; set; }
    [Parameter(Mandatory = false)] public string? CreationErrorMessage { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType DatabaseType { get; set; }
    [Parameter(Mandatory = false)] public string? DocsUrl { get; set; }
    [Parameter(Mandatory = true)] public required bool Enabled { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = true)] public required Guid IntegrationTypeId { get; set; }
    [Parameter(Mandatory = true)] public required Media Logo { get; set; }
    [Parameter(Mandatory = true)] public required int LogoId { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = true)] public required Script Script { get; set; }
    [Parameter(Mandatory = true)] public required int ScriptId { get; set; }
    [Parameter(Mandatory = false)] public object? Secrets { get; set; }
    [Parameter(Mandatory = true)] public required IntegrationTag Tag { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDate { get; set; }

    protected override void ProcessRecord() {
        DynamicIntegrationType outputObject = new(CreatedDate, CreationErrorMessage, DatabaseType, DocsUrl, Enabled, Id, IntegrationTypeId, Logo, LogoId, Name, Script, ScriptId, Secrets, Tag, UpdatedDate);
        WriteObject(outputObject);
    }
}
