using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "MigrationPreviewResponse")]
public class NewMigrationPreviewResponse : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<MigratorDataDto>? MaintenanceTasks { get; set; }
    [Parameter(Mandatory = false)] public ICollection<MigratorDataDto>? Scripts { get; set; }
    [Parameter(Mandatory = false)] public ICollection<MigratorDataDto>? Software { get; set; }
    [Parameter(Mandatory = true)] public required bool SoftwareHasLocalPrerequisites { get; set; }
    [Parameter(Mandatory = false)] public ICollection<MigratorDataDto>? SoftwareVersions { get; set; }

    protected override void ProcessRecord() {
        MigrationPreviewResponse outputObject = new(MaintenanceTasks, Scripts, Software, SoftwareHasLocalPrerequisites, SoftwareVersions);
        WriteObject(outputObject);
    }
}
