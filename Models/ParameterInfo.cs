using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ParameterInfo(
    [property: JsonPropertyName("attributes")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<ParameterAttributes>))]
    ParameterAttributes Attributes,
    [property: JsonPropertyName("customAttributes")]
    ICollection<CustomAttributeData>? CustomAttributes,
    [property: JsonPropertyName("defaultValue")]
    object? DefaultValue,
    [property: JsonPropertyName("hasDefaultValue")]
    bool HasDefaultValue,
    [property: JsonPropertyName("isIn")] bool IsIn,
    [property: JsonPropertyName("isLcid")] bool IsLcid,
    [property: JsonPropertyName("isOptional")]
    bool IsOptional,
    [property: JsonPropertyName("isOut")] bool IsOut,
    [property: JsonPropertyName("isRetval")]
    bool IsRetval,
    [property: JsonPropertyName("member")] MemberInfo Member,
    [property: JsonPropertyName("metadataToken")]
    int MetadataToken,
    [property: JsonPropertyName("name")] string? Name,
    [property: JsonPropertyName("parameterType")]
    Type ParameterType,
    [property: JsonPropertyName("position")]
    int Position,
    [property: JsonPropertyName("rawDefaultValue")]
    object? RawDefaultValue);
