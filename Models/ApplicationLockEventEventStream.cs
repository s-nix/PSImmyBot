using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

public record ApplicationLockEventEventStream {
    [JsonConstructor]
    public ApplicationLockEventEventStream() {
    }
}
