namespace PSImmyBot.Models;

/// <summary>
/// The string or integer value may be used. NewerOrEqualVersion = 0, NotPresent = 1, AnyVersion = 2, ThisVersion = 3, OlderOrEqualVersion = 4, LatestVersion = 5, NoAction = 6, UpdateIfFound = 7
/// </summary>

public enum DesiredSoftwareState {

    NewerOrEqualVersion = 0,

    NotPresent = 1,

    AnyVersion = 2,

    ThisVersion = 3,

    OlderOrEqualVersion = 4,

    LatestVersion = 5,

    NoAction = 6,

    UpdateIfFound = 7,

}
