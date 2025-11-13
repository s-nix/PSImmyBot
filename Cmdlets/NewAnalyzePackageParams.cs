using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "AnalyzePackageParams")]
public class NewAnalyzePackageParams : Cmdlet {
    [Parameter(Mandatory = false)] public string? BlobName { get; set; }
    [Parameter(Mandatory = false)] public string? FileName { get; set; }
    [Parameter(Mandatory = false)] public string? Url { get; set; }

    protected override void ProcessRecord() {
        AnalyzePackageParams outputObject = new(BlobName, FileName, Url);
        WriteObject(outputObject);
    }
}
