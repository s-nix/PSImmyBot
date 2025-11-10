namespace PSImmyBot.Models;

/// <summary>
/// The string or integer value may be used. Pending = 0, Success = 1, Failed = 2, Cancelled = 3, Indeterminable = 4, Resolved = 5
/// </summary>

public enum MaintenanceActionResult {

    Pending = 0,

    Success = 1,

    Failed = 2,

    Cancelled = 3,

    Indeterminable = 4,

    Resolved = 5,

}
