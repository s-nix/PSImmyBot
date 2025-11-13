using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "FastCreateLocalVersionRequestBody")]
public class NewFastCreateLocalVersionRequestBody : Cmdlet {
    [Parameter(Mandatory = true)] public required CreateLocalSoftwareRequestBody Software { get; set; }
    [Parameter(Mandatory = false)] public int? SoftwareId { get; set; }
    [Parameter(Mandatory = true)] public required CreateLocalSoftwareVersionRequestBody SoftwareVersion { get; set; }

    protected override void ProcessRecord() {
        FastCreateLocalVersionRequestBody outputObject = new(Software, SoftwareId, SoftwareVersion);
        WriteObject(outputObject);
    }
}
