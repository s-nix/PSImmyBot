using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetAzureGroupResponse")]
public class NewGetAzureGroupResponse : Cmdlet {
    [Parameter(Mandatory = false)] public string? DisplayName { get; set; }
    [Parameter(Mandatory = false)] public string? Id { get; set; }

    protected override void ProcessRecord() {
        GetAzureGroupResponse outputObject = new(DisplayName, Id);
        WriteObject(outputObject);
    }
}
