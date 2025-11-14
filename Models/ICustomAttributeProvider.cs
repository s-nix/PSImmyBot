using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

public record ICustomAttributeProvider {
    [JsonConstructor]
    public ICustomAttributeProvider() {
    }
}
