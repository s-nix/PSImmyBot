namespace PSImmyBot.Models;

/// <summary>
/// The string or integer value may be used. Enforce = 0, Audit = 1, Monitor = 2, NoAction = 3
/// </summary>

public enum MaintenanceTaskMode {

    Enforce = 0,

    Audit = 1,

    Monitor = 2,

    NoAction = 3,

}
