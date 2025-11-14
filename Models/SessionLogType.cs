namespace PSImmyBot.Models;

/// <summary>
/// The string or integer value may be used. Generic = 0, Error = 1, Command = 2, CommandResult = 3, Progress = 4
/// </summary>

public enum SessionLogType {

    Generic = 0,

    Error = 1,

    Command = 2,

    CommandResult = 3,

    Progress = 4,

}
