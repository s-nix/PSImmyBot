using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "DynamicFormBindResultWithConvertedParameters")]
public class NewDynamicFormBindResultWithConvertedParameters : Cmdlet {
    [Parameter(Mandatory = false)] public IDictionary<string, string>? BindErrors { get; set; }
    [Parameter(Mandatory = false)] public IDictionary<string, object?>? ConvertedParameters { get; set; }
    [Parameter(Mandatory = true)] public required bool HasErrors { get; set; }
    [Parameter(Mandatory = false)] public string? ParameterSetName { get; set; }
    [Parameter(Mandatory = true)] public required ShowCommandInfo ShowCommandInfo { get; set; }

    protected override void ProcessRecord() {
        DynamicFormBindResultWithConvertedParameters outputObject = new(BindErrors, ConvertedParameters, HasErrors, ParameterSetName, ShowCommandInfo);
        WriteObject(outputObject);
    }
}
