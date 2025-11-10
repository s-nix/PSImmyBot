using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record AzureTenantAuthDetails(
    [property: JsonPropertyName("azureTenantPrincipalId")]
    string? AzureTenantPrincipalId,
    [property: JsonPropertyName("customAppRegAppId")]
    string? CustomAppRegAppId,
    [property: JsonPropertyName("customAppRegSecret")]
    string? CustomAppRegSecret,
    [property: JsonPropertyName("selectedPermissionLevel")]
    [property: JsonConverter(typeof(JsonStringEnumConverter<AzurePermissionLevel2>))]
    AzurePermissionLevel2 SelectedPermissionLevel);
