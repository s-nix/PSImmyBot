using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record DefaultScriptTimeouts(
    [property: JsonPropertyName("detection")]
    int Detection,

    [property: JsonPropertyName("action")]
    int Action,

    [property: JsonPropertyName("install")]
    int Install,

    [property: JsonPropertyName("uninstall")]
    int Uninstall,

    [property: JsonPropertyName("upgrade")]
    int Upgrade,

    [property: JsonPropertyName("autoUpdateJob")]
    [property: Obsolete]
    int AutoUpdateJob,

    [property: JsonPropertyName("dynamicVersions")]
    int DynamicVersions
);
