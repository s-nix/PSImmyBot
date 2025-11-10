namespace PSImmyBot.Models;

/// <summary>
/// The string or integer value may be used. NoAction = 0, Install = 1, Update = 2, Uninstall = 3, Download = 4, Reinstall = 5, Downgrade = 6, Undetermined = 7, TaskEnforce = 8, TaskMonitor = 9, TaskAudit = 10
/// </summary>

public enum MaintenanceActionType {

    NoAction = 0,

    Install = 1,

    Update = 2,

    Uninstall = 3,

    Download = 4,

    Reinstall = 5,

    Downgrade = 6,

    Undetermined = 7,

    TaskEnforce = 8,

    TaskMonitor = 9,

    TaskAudit = 10,

}
