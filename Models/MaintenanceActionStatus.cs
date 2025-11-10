namespace PSImmyBot.Models;

/// <summary>
/// The string or integer value may be used. NotStarted = 0, Downloading = 1, PerformingAction = 2, DeterminingResult = 3, Complete = 4, WaitingForPrerequisite = 5, DeterminingAction = 6, Skipped = 7, PendingExecution = 8
/// </summary>

public enum MaintenanceActionStatus {

    NotStarted = 0,

    Downloading = 1,

    PerformingAction = 2,

    DeterminingResult = 3,

    Complete = 4,

    WaitingForPrerequisite = 5,

    DeterminingAction = 6,

    Skipped = 7,

    PendingExecution = 8,

}
