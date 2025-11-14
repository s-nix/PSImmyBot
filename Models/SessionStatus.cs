namespace PSImmyBot.Models;

/// <summary>
/// The string or integer value may be used. Passed = 0, Running = 1, Failed = 2, Created = 3, Cancelled = 4, Postponed = 5, Pending = 6, PartialPassed = 7, PendingConnectivity = 8, Missed = 9, MaxTrackedDevicesPerMonthExceeded = 10, PendingPreflight = 11, PendingEphemeralAgentConnection = 12, MaintenanceForTrackableDevicesNotAllowed = 13
/// </summary>

public enum SessionStatus {

    Passed = 0,

    Running = 1,

    Failed = 2,

    Created = 3,

    Cancelled = 4,

    Postponed = 5,

    Pending = 6,

    PartialPassed = 7,

    PendingConnectivity = 8,

    Missed = 9,

    MaxTrackedDevicesPerMonthExceeded = 10,

    PendingPreflight = 11,

    PendingEphemeralAgentConnection = 12,

    MaintenanceForTrackableDevicesNotAllowed = 13,

}
