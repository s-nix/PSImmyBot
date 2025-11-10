using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record CustomAttributeData(
    [property: JsonPropertyName("attributeType")]
    Type AttributeType,
    [property: JsonPropertyName("constructor")]
    ConstructorInfo Constructor,
    [property: JsonPropertyName("constructorArguments")]
    ICollection<CustomAttributeTypedArgument>? ConstructorArguments,
    [property: JsonPropertyName("namedArguments")]
    ICollection<CustomAttributeNamedArgument>? NamedArguments);
