using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetRdpInfoResponse")]
public class NewGetRdpInfoResponse : Cmdlet {
    [Parameter(Mandatory = false)] public string? RdpFileContent { get; set; }
    [Parameter(Mandatory = false)] public string? RdpFileName { get; set; }
    [Parameter(Mandatory = false)] public string? RdpPassword { get; set; }

    protected override void ProcessRecord() {
        GetRdpInfoResponse outputObject = new(RdpFileContent, RdpFileName, RdpPassword);
        WriteObject(outputObject);
    }
}
