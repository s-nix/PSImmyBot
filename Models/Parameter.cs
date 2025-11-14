using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record Parameter(
    [property: JsonPropertyName("allowNull")]
    bool AllowNull,
    [property: JsonPropertyName("defaultValue")]
    object? DefaultValue,
    [property: JsonPropertyName("defaultValueText")]
    string? DefaultValueText,
    [property: JsonPropertyName("displayName")]
    string? DisplayName,
    [property: JsonPropertyName("hasDropdownParameterSet")]
    bool HasDropdownParameterSet,
    [property: JsonPropertyName("hasParameterSet")]
    bool HasParameterSet,
    [property: JsonPropertyName("helpText")]
    string? HelpText,
    [property: JsonPropertyName("hidden")] bool Hidden,
    [property: JsonPropertyName("isMandatory")]
    bool IsMandatory,
    [property: JsonPropertyName("isValueStripped")]
    bool IsValueStripped,
    [property: JsonPropertyName("name")] string? Name,
    [property: JsonPropertyName("oauthConsentParameterData")]
    OauthConsentData OauthConsentParameterData,
    [property: JsonPropertyName("onlyForHelpText")]
    bool OnlyForHelpText,
    [property: JsonPropertyName("parameterType")]
    [property: System.ComponentModel.DataAnnotations.Required]
    ParameterType ParameterType,
    [property: JsonPropertyName("position")]
    int Position,
    [property: JsonPropertyName("showDropdownAsRadioButtons")]
    bool ShowDropdownAsRadioButtons,
    [property: JsonPropertyName("showRawHelpText")]
    bool ShowRawHelpText,
    [property: JsonPropertyName("validDropdownValues")]
    ICollection<ParameterDropdownTextValue>? ValidDropdownValues,
    [property: JsonPropertyName("validParamSetValues")]
    ICollection<string>? ValidParamSetValues,
    [property: JsonPropertyName("valueFromPipeline")]
    bool ValueFromPipeline);
