using System.Management.Automation;
using PSImmyBot.Models;
using ActionPreference = PSImmyBot.Models.ActionPreference;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "Script")]
public class NewScript : Cmdlet {
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDate { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDate { get; set; }
    [Parameter(Mandatory = false)] public int? CreatedBy { get; set; }
    [Parameter(Mandatory = false)] public int? UpdatedBy { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public string? Action { get; set; }
    [Parameter(Mandatory = true)] public required ScriptLanguage ScriptLanguage { get; set; }
    [Parameter(Mandatory = false)] public int? Timeout { get; set; }
    [Parameter(Mandatory = true)] public required ScriptExecutionContext ScriptExecutionContext { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType ScriptType { get; set; }
    [Parameter(Mandatory = true)] public required bool ReadOnly { get; set; }
    [Parameter(Mandatory = false)] public string? Identifier { get; set; }
    [Parameter(Mandatory = true)] public required ScriptCategory ScriptCategory { get; set; }
    [Parameter(Mandatory = true)] public required ScriptOutputType OutputType { get; set; }
    [Parameter(Mandatory = false)] public string? PublicStorageDownloadUrl { get; set; }
    [Parameter(Mandatory = false)] public string? ScriptHash { get; set; }
    [Parameter(Mandatory = false)] public string? ScriptCacheName { get; set; }
    [Parameter(Mandatory = false)] public IDictionary<string, object?>? Variables { get; set; }
    [Parameter(Mandatory = false)] public IDictionary<string, object?>? Parameters { get; set; }
    [Parameter(Mandatory = false)] public IDictionary<string, object?>? ParameterOverrides { get; set; }
    [Parameter(Mandatory = false)] public string? DynamicProviderStoreId { get; set; }
    [Parameter(Mandatory = true)] public required DynamicIntegrationTypeProperties DynamicIntegrationTypeProperties { get; set; }
    [Parameter(Mandatory = false)] public int? ProviderLinkIdForMaintenanceItem { get; set; }
    [Parameter(Mandatory = false)] public ICollection<TenantScript>? TenantRelationships { get; set; }
    [Parameter(Mandatory = false)] public ICollection<ChangeRequest>? ChangeRequests { get; set; }
    [Parameter(Mandatory = true)] public required User CreatedByUser { get; set; }
    [Parameter(Mandatory = true)] public required User UpdatedByUser { get; set; }
    [Parameter(Mandatory = true)] public required bool Hidden { get; set; }
    [Parameter(Mandatory = true)] public required ActionPreference ErrorActionPreference { get; set; }
    [Parameter(Mandatory = true)] public required bool SkipPreflight { get; set; }
    [Parameter(Mandatory = true)] public required bool SkipBusinessHoursCheck { get; set; }
    [Parameter(Mandatory = true)] public required DynamicIntegrationType DynamicIntegrationType { get; set; }
    [Parameter(Mandatory = true)] public required InventoryTaskScript InventoryTaskScript { get; set; }

    protected override void ProcessRecord() {
        Script outputObject = new(CreatedDate, UpdatedDate, CreatedBy, UpdatedBy, Name, Id, Action, ScriptLanguage, Timeout, ScriptExecutionContext, ScriptType, ReadOnly, Identifier, ScriptCategory, OutputType, PublicStorageDownloadUrl, ScriptHash, ScriptCacheName, Variables, Parameters, ParameterOverrides, DynamicProviderStoreId, DynamicIntegrationTypeProperties, ProviderLinkIdForMaintenanceItem, TenantRelationships, ChangeRequests, CreatedByUser, UpdatedByUser, Hidden, ErrorActionPreference, SkipPreflight, SkipBusinessHoursCheck, DynamicIntegrationType, InventoryTaskScript);
        WriteObject(outputObject);
    }
}
