using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ScriptReferenceCounts(
    [property: JsonPropertyName("globalMaintenanceTaskCount")]
    int GlobalMaintenanceTaskCount,
    [property: JsonPropertyName("globalSoftwareCount")]
    int GlobalSoftwareCount,
    [property: JsonPropertyName("globalSoftwareVersionCount")]
    int GlobalSoftwareVersionCount,
    [property: JsonPropertyName("localMaintenanceTaskCount")]
    int LocalMaintenanceTaskCount,
    [property: JsonPropertyName("localSoftwareCount")]
    int LocalSoftwareCount,
    [property: JsonPropertyName("localSoftwareVersionCount")]
    int LocalSoftwareVersionCount,
    [property: JsonPropertyName("total")] int Total);
