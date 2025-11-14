namespace PSImmyBot.Models;

/// <summary>
/// The string or integer value may be used. Unknown = 0, String = 1, ExpandString = 2, Binary = 3, DWord = 4, MultiString = 7, QWord = 11, None = -1
/// </summary>

public enum RegistryValueKindDto {

    Unknown = 0,

    String = 1,

    ExpandString = 2,

    Binary = 3,

    DWord = 4,

    MultiString = 5,

    QWord = 6,

    None = 7,

}
