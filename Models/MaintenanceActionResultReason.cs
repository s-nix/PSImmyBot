namespace PSImmyBot.Models;

/// <summary>
/// The string or integer value may be used. NoLicenseAvailable = 0, SoftwareNotFound = 1, DetectionActionFailed = 2, TaskNotFound = 3, TaskNotCompliant = 4, TaskCompliant = 5, TaskSetIsMissing = 6, TaskTestIsMissing = 7, TaskGetIsMissing = 8, SoftwareConfigurationTaskMissing = 9, TaskModeIsMissing = 10, DeviceOffline = 11, RebootsSuppressed = 12
/// </summary>

public enum MaintenanceActionResultReason {

    NoLicenseAvailable = 0,

    SoftwareNotFound = 1,

    DetectionActionFailed = 2,

    TaskNotFound = 3,

    TaskNotCompliant = 4,

    TaskCompliant = 5,

    TaskSetIsMissing = 6,

    TaskTestIsMissing = 7,

    TaskGetIsMissing = 8,

    SoftwareConfigurationTaskMissing = 9,

    TaskModeIsMissing = 10,

    DeviceOffline = 11,

    RebootsSuppressed = 12,

}
