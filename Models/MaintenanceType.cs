namespace PSImmyBot.Models;

/// <summary>
/// The string or integer value may be used. GlobalSoftware = 0, LocalSoftware = 1, WindowsUpdate = 2, ChocolateySoftware = 3, NiniteSoftware = 4, LocalMaintenanceTask = 5, GlobalMaintenanceTask = 6, AgentUpdate = 7
/// </summary>

public enum MaintenanceType {

    GlobalSoftware = 0,

    LocalSoftware = 1,

    WindowsUpdate = 2,

    ChocolateySoftware = 3,

    NiniteSoftware = 4,

    LocalMaintenanceTask = 5,

    GlobalMaintenanceTask = 6,

    AgentUpdate = 7,

}
