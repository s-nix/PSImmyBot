using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record CreateBrandingRequestBody(
    [property: JsonPropertyName("backgroundColor")]
    string? BackgroundColor,
    [property: JsonPropertyName("description")]
    string? Description,
    [property: JsonPropertyName("endDate")]
    DateTimeOffset? EndDate,
    [property: JsonPropertyName("foregroundColor")]
    string? ForegroundColor,
    [property: JsonPropertyName("fromAddress")]
    string? FromAddress,
    [property: JsonPropertyName("ignoreYear")]
    bool? IgnoreYear,
    [property: JsonPropertyName("logoAltText")]
    string? LogoAltText,
    [property: JsonPropertyName("logoUri")]
    string? LogoUri,
    [property: JsonPropertyName("mascotImgUri")]
    string? MascotImgUri,
    [property: JsonPropertyName("mascotName")]
    string? MascotName,
    [property: JsonPropertyName("startDate")]
    DateTimeOffset? StartDate,
    [property: JsonPropertyName("tableHeaderColor")]
    string? TableHeaderColor,
    [property: JsonPropertyName("tableHeaderTextColor")]
    string? TableHeaderTextColor,
    [property: JsonPropertyName("tenantId")]
    int? TenantId,
    [property: JsonPropertyName("textColor")]
    string? TextColor,
    [property: JsonPropertyName("timeFormat")]
    string? TimeFormat);
