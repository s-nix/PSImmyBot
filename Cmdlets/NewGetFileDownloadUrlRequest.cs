using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetFileDownloadUrlRequest")]
public class NewGetFileDownloadUrlRequest : Cmdlet {
    [Parameter(Mandatory = false)] public string? BlobName { get; set; }
    [Parameter(Mandatory = true)] public required DatabaseType DatabaseType { get; set; }

    protected override void ProcessRecord() {
        GetFileDownloadUrlRequest outputObject = new(BlobName, DatabaseType);
        WriteObject(outputObject);
    }
}
