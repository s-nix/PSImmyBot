using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record CircuitBreakerState(
    [property: JsonPropertyName("circuitState")]
    string? CircuitState,
    [property: JsonPropertyName("lastException")]
    LastException LastException,
    [property: JsonPropertyName("policyName")]
    string? PolicyName);
