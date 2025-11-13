using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "SoftwareFileUploadData")]
public class NewSoftwareFileUploadData : Cmdlet {
    [Parameter(Mandatory = false)] public string? FileBlobName { get; set; }
    [Parameter(Mandatory = false)] public string? InstallerFile { get; set; }
    [Parameter(Mandatory = true)] public required SoftwareVersionInstallerType InstallerType { get; set; }
    [Parameter(Mandatory = false)] public string? Md5Hash { get; set; }
    [Parameter(Mandatory = true)] public required PackageType PackageType { get; set; }
    [Parameter(Mandatory = true)] public required Guid RelativeCacheSourcePath { get; set; }

    protected override void ProcessRecord() {
        SoftwareFileUploadData outputObject = new(FileBlobName, InstallerFile, InstallerType, Md5Hash, PackageType, RelativeCacheSourcePath);
        WriteObject(outputObject);
    }
}
