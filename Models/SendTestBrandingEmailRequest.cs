using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record SendTestBrandingEmailRequest(
    [property: JsonPropertyName("branding")]
    [property: System.ComponentModel.DataAnnotations.Required]
    CreateBrandingRequestBody Branding, [property: JsonPropertyName("to")] string? To);
