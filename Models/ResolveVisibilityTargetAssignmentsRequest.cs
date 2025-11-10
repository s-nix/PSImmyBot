using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ResolveVisibilityTargetAssignmentsRequest(
    [property: JsonPropertyName("computerId")]
    int? ComputerId,
    [property: JsonPropertyName("personId")]
    int? PersonId,
    [property: JsonPropertyName("tenantId")]
    int? TenantId,
    [property: JsonPropertyName("visibility")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<TargetVisibility>))]
    TargetVisibility Visibility);
