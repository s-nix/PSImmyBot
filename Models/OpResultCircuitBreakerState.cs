using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record OpResultCircuitBreakerState(
    [property: JsonPropertyName("circuitState")]
    string? CircuitState,
    [property: JsonPropertyName("lastException")]
    LastException LastException,
    [property: JsonPropertyName("lastResult")]
    OpResult LastResult,
    [property: JsonPropertyName("policyName")]
    string? PolicyName);
