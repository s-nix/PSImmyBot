using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record RegistryValueDto(
    [property: JsonPropertyName("binaryValue")]
    string? BinaryValue,
    [property: JsonPropertyName("dWordValue")]
    int? DWordValue,
    [property: JsonPropertyName("kind")]
    [property: System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
    [property: JsonConverter(typeof(JsonStringEnumConverter<RegistryValueKindDto>))]
    RegistryValueKindDto Kind,
    [property: JsonPropertyName("multiStringValue")]
    ICollection<string>? MultiStringValue,
    [property: JsonPropertyName("parentKeyPath")]
    string? ParentKeyPath,
    [property: JsonPropertyName("qWordValue")]
    long? QWordValue,
    [property: JsonPropertyName("stringValue")]
    string? StringValue,
    [property: JsonPropertyName("valueName")]
    string? ValueName);
