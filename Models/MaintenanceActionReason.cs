namespace PSImmyBot.Models;

/// <summary>
/// The string or integer value may be used. SoftwareMissing = 0, UpdateAvailable = 1, UpToDate = 2, NotAssigned = 3, TestFailed = 4, SoftwareDetected = 5, OlderVersionRequired = 6, NoApplicableSoftwareVersion = 7, NoAction = 8, Undetermined = 9, TaskEnforce = 10, TaskAudit = 11, TaskMonitor = 12, TaskNotCompliant = 13, TaskCompliant = 14, DeviceOffline = 15, RepairTriggered = 16
/// </summary>

public enum MaintenanceActionReason {

    SoftwareMissing = 0,

    UpdateAvailable = 1,

    UpToDate = 2,

    NotAssigned = 3,

    TestFailed = 4,

    SoftwareDetected = 5,

    OlderVersionRequired = 6,

    NoApplicableSoftwareVersion = 7,

    NoAction = 8,

    Undetermined = 9,

    TaskEnforce = 10,

    TaskAudit = 11,

    TaskMonitor = 12,

    TaskNotCompliant = 13,

    TaskCompliant = 14,

    DeviceOffline = 15,

    RepairTriggered = 16,

}
