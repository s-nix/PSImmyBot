using System.Text.Json.Serialization;

namespace PSImmyBot.Models;

[method: JsonConstructor]
public record ScriptActionAuditResult([property: JsonPropertyName("audit")] ScriptActionAudit Audit, [property: JsonPropertyName("total")] int Total);
