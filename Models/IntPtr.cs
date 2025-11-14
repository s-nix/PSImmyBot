using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

public record IntPtr {
    [JsonConstructor]
    public IntPtr() {
    }
}
