namespace PSImmyBot.Models;

/// <summary>
/// The string or integer value may be used. UnKnown = 0, Created = 1, LoggedIn = 2, LoggedOut = 3, NotYetActivated = 4, Activated = 5
/// </summary>

public enum CustomerPortalSessionStatus {

    UnKnown = 0,

    Created = 1,

    LoggedIn = 2,

    LoggedOut = 3,

    NotYetActivated = 4,

    Activated = 5,

}
