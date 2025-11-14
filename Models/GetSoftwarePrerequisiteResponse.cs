using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetSoftwarePrerequisiteResponse(
    [property: JsonPropertyName("actionToPerform")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<ActionToPerform>))]
    ActionToPerform ActionToPerform,
    [property: JsonPropertyName("condition")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<Condition>))]
    Condition Condition,
    [property: JsonPropertyName("softwaresForCondition")]
    ICollection<GetSpecifiedSoftwareResponse>? SoftwaresForCondition,
    [property: JsonPropertyName("softwaresToPerformActionOn")]
    ICollection<GetSpecifiedSoftwareResponse>? SoftwaresToPerformActionOn,
    [property: JsonPropertyName("subjectQualifier")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<SubjectQualifier>))]
    SubjectQualifier SubjectQualifier);
