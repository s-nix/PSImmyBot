using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetSpecifiedSoftwareResponse")]
public class NewGetSpecifiedSoftwareResponse : Cmdlet {
    [Parameter(Mandatory = false)] public string? SoftwareIdentifier { get; set; }
    [Parameter(Mandatory = true)] public required SoftwareType SoftwareType { get; set; }

    protected override void ProcessRecord() {
        GetSpecifiedSoftwareResponse outputObject = new(SoftwareIdentifier, SoftwareType);
        WriteObject(outputObject);
    }
}
