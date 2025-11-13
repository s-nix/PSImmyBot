using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "Media")]
public class NewMedia : Cmdlet {
    [Parameter(Mandatory = false)] public string? BlobReference { get; set; }
    [Parameter(Mandatory = true)] public required MediaCategory Category { get; set; }
    [Parameter(Mandatory = false)] public int? CreatedBy { get; set; }
    [Parameter(Mandatory = true)] public required User CreatedByUser { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDate { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType DatabaseType { get; set; }
    [Parameter(Mandatory = false)] public ICollection<DynamicIntegrationType>? DynamicIntegrationTypes { get; set; }
    [Parameter(Mandatory = false)] public string? FileName { get; set; }
    [Parameter(Mandatory = false)] public ICollection<GlobalSoftware>? GlobalSoftware { get; set; }
    [Parameter(Mandatory = false)] public ICollection<MaintenanceTask>? IconForMaintenanceTasks { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public ICollection<LocalSoftware>? LocalSoftware { get; set; }
    [Parameter(Mandatory = false)] public string? MimeType { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = false)] public string? PackageHash { get; set; }
    [Parameter(Mandatory = false)] public string? RelativeCacheSourcePath { get; set; }
    [Parameter(Mandatory = false)] public ICollection<TenantMedia>? TenantRelationships { get; set; }
    [Parameter(Mandatory = false)] public int? UpdatedBy { get; set; }
    [Parameter(Mandatory = true)] public required User UpdatedByUser { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDate { get; set; }

    protected override void ProcessRecord() {
        Media outputObject = new(BlobReference, Category, CreatedBy, CreatedByUser, CreatedDate, DatabaseType, DynamicIntegrationTypes, FileName, GlobalSoftware, IconForMaintenanceTasks, Id, LocalSoftware, MimeType, Name, PackageHash, RelativeCacheSourcePath, TenantRelationships, UpdatedBy, UpdatedByUser, UpdatedDate);
        WriteObject(outputObject);
    }
}
