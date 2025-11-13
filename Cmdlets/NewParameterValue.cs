using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ParameterValue")]
public class NewParameterValue : Cmdlet {
    [Parameter(Mandatory = false)] public object? Value { get; set; }

    protected override void ProcessRecord() {
        ParameterValue outputObject = new(Value);
        WriteObject(outputObject);
    }
}
