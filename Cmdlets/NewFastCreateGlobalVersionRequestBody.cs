using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "FastCreateGlobalVersionRequestBody")]
public class NewFastCreateGlobalVersionRequestBody : Cmdlet {
    [Parameter(Mandatory = true)] public required CreateGlobalSoftwareRequestBody Software { get; set; }
    [Parameter(Mandatory = false)] public int? SoftwareId { get; set; }
    [Parameter(Mandatory = true)] public required CreateGlobalSoftwareVersionRequestBody SoftwareVersion { get; set; }

    protected override void ProcessRecord() {
        FastCreateGlobalVersionRequestBody outputObject = new(Software, SoftwareId, SoftwareVersion);
        WriteObject(outputObject);
    }
}
