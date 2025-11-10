using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record CalculateTargetedComputerResponse([property: JsonPropertyName("cn")] string? Cn,
    [property: JsonPropertyName("ct")] ICollection<int>? Ct,
    [property: JsonPropertyName("dr")] int? Dr, [property: JsonPropertyName("id")] int Id, [property: JsonPropertyName("obs")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<ComputerOnboardingStatus>))]
    ComputerOnboardingStatus Obs, [property: JsonPropertyName("on")] bool On, [property: JsonPropertyName("os")] string? Os, [property: JsonPropertyName("ppi")] int? Ppi, [property: JsonPropertyName("ppn")] string? Ppn,
    [property: JsonPropertyName("sb")] bool Sb,
    [property: JsonPropertyName("sn")] string? Sn, [property: JsonPropertyName("ti")] int Ti, [property: JsonPropertyName("tn")] string? Tn);
