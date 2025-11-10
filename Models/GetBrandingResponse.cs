using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record GetBrandingResponse(
    [property: JsonPropertyName("backgroundColor")]
    string? BackgroundColor,
    [property: JsonPropertyName("createdDateUTC")]
    DateTimeOffset CreatedDateUtc,
    [property: JsonPropertyName("description")]
    string? Description,
    [property: JsonPropertyName("endDate")]
    DateTimeOffset? EndDate,
    [property: JsonPropertyName("foregroundColor")]
    string? ForegroundColor,
    [property: JsonPropertyName("fromAddress")]
    string? FromAddress,
    [property: JsonPropertyName("id")] int Id,
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
    [property: JsonPropertyName("tenantName")]
    string? TenantName,
    [property: JsonPropertyName("textColor")]
    string? TextColor,
    [property: JsonPropertyName("timeFormat")]
    string? TimeFormat,
    [property: JsonPropertyName("updatedBy")]
    string? UpdatedBy,
    [property: JsonPropertyName("updatedDateUTC")]
    DateTimeOffset UpdatedDateUtc);
