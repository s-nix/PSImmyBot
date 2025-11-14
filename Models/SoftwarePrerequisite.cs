using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record SoftwarePrerequisite(
    [property: JsonPropertyName("actionToPerform")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<ActionToPerform>))]
    ActionToPerform ActionToPerform,
    [property: JsonPropertyName("condition")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<Condition>))]
    Condition Condition,
    [property: JsonPropertyName("softwaresForCondition")]
    ICollection<SoftwareSpecifier>? SoftwaresForCondition,
    [property: JsonPropertyName("softwareSpecifiers")]
    ICollection<SoftwareSpecifier>? SoftwareSpecifiers,
    [property: JsonPropertyName("softwaresToPerformActionOn")]
    ICollection<SoftwareSpecifier>? SoftwaresToPerformActionOn,
    [property: JsonPropertyName("subjectQualifier")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<SubjectQualifier>))]
    SubjectQualifier SubjectQualifier);
