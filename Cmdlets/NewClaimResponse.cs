using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ClaimResponse")]
public class NewClaimResponse : Cmdlet {
    [Parameter(Mandatory = false)] public string? Type { get; set; }
    [Parameter(Mandatory = false)] public string? Value { get; set; }

    protected override void ProcessRecord() {
        ClaimResponse outputObject = new(Type, Value);
        WriteObject(outputObject);
    }
}
