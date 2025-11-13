using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "UpdateGlobalMediaPayload")]
public class NewUpdateGlobalMediaPayload : Cmdlet {
    [Parameter(Mandatory = false)] public string? BlobReference { get; set; }
    [Parameter(Mandatory = true)] public required MediaCategory Category { get; set; }
    [Parameter(Mandatory = false)] public string? FileName { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public string? MimeType { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = false)] public string? PackageHash { get; set; }
    [Parameter(Mandatory = false)] public string? RelativeCacheSourcePath { get; set; }

    protected override void ProcessRecord() {
        UpdateGlobalMediaPayload outputObject = new(BlobReference, Category, FileName, Id, MimeType, Name, PackageHash, RelativeCacheSourcePath);
        WriteObject(outputObject);
    }
}
