namespace PSImmyBot.Models;

/// <summary>
/// The string or integer value may be used. System = 0, CurrentUser = 1, Metascript = 2, CloudScript = 4
/// </summary>

public enum ScriptExecutionContext {

    System = 0,

    CurrentUser = 1,

    Metascript = 2,

    CloudScript = 3,

}
