namespace PSImmyBot.Models;

/// <summary>
/// The string or integer value may be used. Standard = 1, VarArgs = 2, Any = 3, HasThis = 32, ExplicitThis = 64
/// </summary>

public enum CallingConventions {

    Standard = 0,

    VarArgs = 1,

    Any = 2,

    HasThis = 3,

    ExplicitThis = 4,

}
