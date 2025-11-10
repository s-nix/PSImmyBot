namespace PSImmyBot.Models;

/// <summary>
/// The string or integer value may be used. AgentConnected = 1, AgentDisconnected = 2, AgentCreated = 3, AgentDeleted = 4, MaintenanceActionStarted = 5, MaintenanceActionCompleted = 6, ComputerOnline = 7, ComputerOffline = 8, EphemeralAgentSessionCreated = 9, EphemeralAgentSessionConnected = 10, EphemeralAgentSessionConnectionTimeout = 11, EphemeralAgentSessionNotConnected = 12, EphemeralAgentSessionConnectionLost = 13, EphemeralAgentSessionIdleShutdown = 14, EphemeralAgentSessionZombieKill = 15, EphemeralAgentSessionCreationFailure = 16, EphemeralAgentSessionDisconnected = 17, RemoteSessionStarted = 18, RemoteSessionEnded = 19, EphemeralAgentSessionUpdateInstall = 20, AgentUpdated = 21, EphemeralAgentSessionAlreadyConnected = 22, EphemeralAgentSessionDisposed = 23
/// </summary>

public enum TimelineEventType {

    AgentConnected = 0,

    AgentDisconnected = 1,

    AgentCreated = 2,

    AgentDeleted = 3,

    MaintenanceActionStarted = 4,

    MaintenanceActionCompleted = 5,

    ComputerOnline = 6,

    ComputerOffline = 7,

    EphemeralAgentSessionCreated = 8,

    EphemeralAgentSessionConnected = 9,

    EphemeralAgentSessionConnectionTimeout = 10,

    EphemeralAgentSessionNotConnected = 11,

    EphemeralAgentSessionConnectionLost = 12,

    EphemeralAgentSessionIdleShutdown = 13,

    EphemeralAgentSessionZombieKill = 14,

    EphemeralAgentSessionCreationFailure = 15,

    EphemeralAgentSessionDisconnected = 16,

    RemoteSessionStarted = 17,

    RemoteSessionEnded = 18,

    EphemeralAgentSessionUpdateInstall = 19,

    AgentUpdated = 20,

    EphemeralAgentSessionAlreadyConnected = 21,

    EphemeralAgentSessionDisposed = 22,

}
