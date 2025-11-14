using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "ParameterDropdownTextValue")]
public class NewParameterDropdownTextValue : Cmdlet {
    [Parameter(Mandatory = false)] public string? Text { get; set; }
    [Parameter(Mandatory = false)] public string? Value { get; set; }

    protected override void ProcessRecord() {
        ParameterDropdownTextValue outputObject = new(Text, Value);
        WriteObject(outputObject);
    }
}
