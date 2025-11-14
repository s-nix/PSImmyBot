namespace PSImmyBot.Models;

/// <summary>
/// The string or integer value may be used. None = 0, SpecialName = 512, RTSpecialName = 1024, HasDefault = 4096, Reserved2 = 8192, Reserved3 = 16384, Reserved4 = 32768, ReservedMask = 62464
/// </summary>

public enum PropertyAttributes {

    None = 0,

    SpecialName = 1,

    RtSpecialName = 2,

    HasDefault = 3,

    Reserved2 = 4,

    Reserved3 = 5,

    Reserved4 = 6,

    ReservedMask = 7,

}
