using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ParentTenantInfo([property: JsonPropertyName("id")] int Id, [property: JsonPropertyName("name")] string? Name);
