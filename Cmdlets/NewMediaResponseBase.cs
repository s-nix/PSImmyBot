using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "MediaResponseBase")]
public class NewMediaResponseBase : Cmdlet {
    [Parameter(Mandatory = false)] public string? BlobReference { get; set; }
    [Parameter(Mandatory = true)] public required MediaCategory Category { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDateUtc { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType DatabaseType { get; set; }
    [Parameter(Mandatory = false)] public string? FileName { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public string? MimeType { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = false)] public string? PackageHash { get; set; }
    [Parameter(Mandatory = false)] public string? RelativeCacheSourcePath { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDateUtc { get; set; }

    protected override void ProcessRecord() {
        MediaResponseBase outputObject = new(BlobReference, Category, CreatedDateUtc, DatabaseType, FileName, Id, MimeType, Name, PackageHash, RelativeCacheSourcePath, UpdatedDateUtc);
        WriteObject(outputObject);
    }
}
