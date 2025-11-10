using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record CustomAttributeNamedArgument(
    [property: JsonPropertyName("isField")]
    bool IsField,
    [property: JsonPropertyName("memberInfo")]
    MemberInfo MemberInfo,
    [property: JsonPropertyName("memberName")]
    string? MemberName,
    [property: JsonPropertyName("typedValue")]
    CustomAttributeTypedArgument TypedValue);
