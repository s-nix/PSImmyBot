namespace PSImmyBot.Models;

/// <summary>
/// The string or integer value may be used. DeleteExisting = 0, GenerateNewDeviceId = 1, OverwriteExisting = 2
/// </summary>

public enum AgentIdentificationManualResolutionDecision {

    DeleteExisting = 0,

    GenerateNewDeviceId = 1,

    OverwriteExisting = 2,

}
