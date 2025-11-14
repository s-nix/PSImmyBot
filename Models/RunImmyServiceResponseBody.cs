using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record RunImmyServiceResponseBody(
    [property: JsonPropertyName("sessionsAlreadyInProgress")]
    ICollection<RunImmyServiceResponseSession>? SessionsAlreadyInProgress,
    [property: JsonPropertyName("sessionsStarted")]
    ICollection<RunImmyServiceResponseSession>? SessionsStarted);
