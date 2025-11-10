namespace PSImmyBot.Models;

/// <summary>
/// The string or integer value may be used. Alias = 1, Function = 2, Filter = 4, Cmdlet = 8, ExternalScript = 16, Application = 32, Script = 64, Configuration = 256, All = 383
/// </summary>

public enum CommandTypes {

    Alias = 0,

    Function = 1,

    Filter = 2,

    Cmdlet = 3,

    ExternalScript = 4,

    Application = 5,

    Script = 6,

    Configuration = 7,

    All = 8,

}
