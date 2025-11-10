using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record AgentUpdateFormSchema([property: JsonPropertyName("inputs")] ICollection<AgentUpdateFormSchemaInput>? Inputs);
