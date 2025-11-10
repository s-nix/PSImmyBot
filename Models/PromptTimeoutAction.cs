namespace PSImmyBot.Models;

/// <summary>
/// The string or integer value may be used. Reboot = 0, Suppress = 1, FailSession = 2
/// </summary>

public enum PromptTimeoutAction {

    Reboot = 0,

    Suppress = 1,

    FailSession = 2,

}
