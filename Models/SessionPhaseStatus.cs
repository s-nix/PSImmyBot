namespace PSImmyBot.Models;

/// <summary>
/// The string or integer value may be used. Unstarted = 0, Skipped = 1, Running = 2, Succeeded = 3, Failed = 4
/// </summary>

public enum SessionPhaseStatus {

    Unstarted = 0,

    Skipped = 1,

    Running = 2,

    Succeeded = 3,

    Failed = 4,

}
