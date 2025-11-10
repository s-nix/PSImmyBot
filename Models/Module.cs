using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record Module(
    [property: JsonPropertyName("assembly")]
    Assembly Assembly,
    [property: JsonPropertyName("customAttributes")]
    ICollection<CustomAttributeData>? CustomAttributes,
    [property: JsonPropertyName("fullyQualifiedName")]
    string? FullyQualifiedName,
    [property: JsonPropertyName("mdStreamVersion")]
    int MdStreamVersion,
    [property: JsonPropertyName("metadataToken")]
    int MetadataToken,
    [property: JsonPropertyName("moduleHandle")]
    ModuleHandle ModuleHandle,
    [property: JsonPropertyName("moduleVersionId")]
    Guid ModuleVersionId,
    [property: JsonPropertyName("name")] string? Name,
    [property: JsonPropertyName("scopeName")]
    string? ScopeName);
