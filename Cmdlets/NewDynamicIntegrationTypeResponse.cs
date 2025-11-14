using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "DynamicIntegrationTypeResponse")]
public class NewDynamicIntegrationTypeResponse : Cmdlet {
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDateUtc { get; set; }
    [Parameter(Mandatory = false)] public string? CreationErrorMessage { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType DatabaseType { get; set; }
    [Parameter(Mandatory = false)] public string? DocsUrl { get; set; }
    [Parameter(Mandatory = true)] public required bool Enabled { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = true)] public required Guid IntegrationTypeId { get; set; }
    [Parameter(Mandatory = true)] public required GlobalMediaResponse Logo { get; set; }
    [Parameter(Mandatory = true)] public required int LogoId { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = true)] public required int ScriptId { get; set; }
    [Parameter(Mandatory = true)] public required IntegrationTag Tag { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDateUtc { get; set; }

    protected override void ProcessRecord() {
        DynamicIntegrationTypeResponse outputObject = new(CreatedDateUtc, CreationErrorMessage, DatabaseType, DocsUrl, Enabled, Id, IntegrationTypeId, Logo, LogoId, Name, ScriptId, Tag, UpdatedDateUtc);
        WriteObject(outputObject);
    }
}
