using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "Parameter")]
public class NewParameter : Cmdlet {
    [Parameter(Mandatory = true)] public required bool AllowNull { get; set; }
    [Parameter(Mandatory = false)] public object? DefaultValue { get; set; }
    [Parameter(Mandatory = false)] public string? DefaultValueText { get; set; }
    [Parameter(Mandatory = false)] public string? DisplayName { get; set; }
    [Parameter(Mandatory = true)] public required bool HasDropdownParameterSet { get; set; }
    [Parameter(Mandatory = true)] public required bool HasParameterSet { get; set; }
    [Parameter(Mandatory = false)] public string? HelpText { get; set; }
    [Parameter(Mandatory = true)] public required bool Hidden { get; set; }
    [Parameter(Mandatory = true)] public required bool IsMandatory { get; set; }
    [Parameter(Mandatory = true)] public required bool IsValueStripped { get; set; }
    [Parameter(Mandatory = false)] public string? Name { get; set; }
    [Parameter(Mandatory = true)] public required OauthConsentData OauthConsentParameterData { get; set; }
    [Parameter(Mandatory = true)] public required bool OnlyForHelpText { get; set; }
    [Parameter(Mandatory = true)] public required ParameterType ParameterType { get; set; }
    [Parameter(Mandatory = true)] public required int Position { get; set; }
    [Parameter(Mandatory = true)] public required bool ShowDropdownAsRadioButtons { get; set; }
    [Parameter(Mandatory = true)] public required bool ShowRawHelpText { get; set; }
    [Parameter(Mandatory = false)] public ICollection<ParameterDropdownTextValue>? ValidDropdownValues { get; set; }
    [Parameter(Mandatory = false)] public ICollection<string>? ValidParamSetValues { get; set; }
    [Parameter(Mandatory = true)] public required bool ValueFromPipeline { get; set; }

    protected override void ProcessRecord() {
        Parameter outputObject = new(AllowNull, DefaultValue, DefaultValueText, DisplayName, HasDropdownParameterSet, HasParameterSet, HelpText, Hidden, IsMandatory, IsValueStripped, Name, OauthConsentParameterData, OnlyForHelpText, ParameterType, Position, ShowDropdownAsRadioButtons, ShowRawHelpText, ValidDropdownValues, ValidParamSetValues, ValueFromPipeline);
        WriteObject(outputObject);
    }
}
