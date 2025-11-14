namespace PSImmyBot.Models;

/// <summary>
/// The string or integer value may be used. All = 1, OnlyPendingIdentification = 2, OnlyIdentified = 3, RequiresManualDecision = 4, AssociatedToDeletedComputers = 5
/// </summary>

public enum ProviderAgentFilter {

    All = 0,

    OnlyPendingIdentification = 1,

    OnlyIdentified = 2,

    RequiresManualDecision = 3,

    AssociatedToDeletedComputers = 4,

}
