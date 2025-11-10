using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

public record DefaultScriptTimeouts {
    [JsonConstructor]
    [Obsolete]
    public DefaultScriptTimeouts(int @action, int @autoUpdateJob, int @detection, int @dynamicVersions, int @install, int @uninstall, int @upgrade) {
        Detection = @detection;
        Action = @action;
        Install = @install;
        Uninstall = @uninstall;
        Upgrade = @upgrade;
        AutoUpdateJob = @autoUpdateJob;
        DynamicVersions = @dynamicVersions;
    }

    [JsonPropertyName("detection")]
    public int Detection { get; init; }

    [JsonPropertyName("action")]
    public int Action { get; init; }

    [JsonPropertyName("install")]
    public int Install { get; init; }

    [JsonPropertyName("uninstall")]
    public int Uninstall { get; init; }

    [JsonPropertyName("upgrade")]
    public int Upgrade { get; init; }

    [JsonPropertyName("autoUpdateJob")]
    [Obsolete]
    public int AutoUpdateJob { get; init; }

    [JsonPropertyName("dynamicVersions")]
    public int DynamicVersions { get; init; }
}
