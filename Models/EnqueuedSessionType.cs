namespace PSImmyBot.Models;

/// <summary>
/// The string or integer value may be used. HangfireAdhoc = 1, HangfireOnboarding = 2, HangfireScheduled = 3, HangfireConnectivityTriggered = 4, NotHangfire = 5
/// </summary>

public enum EnqueuedSessionType {

    HangfireAdhoc = 0,

    HangfireOnboarding = 1,

    HangfireScheduled = 2,

    HangfireConnectivityTriggered = 3,

    NotHangfire = 4,

}
