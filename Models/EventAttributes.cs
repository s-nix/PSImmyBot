namespace PSImmyBot.Models;

/// <summary>
/// The string or integer value may be used. None = 0, SpecialName = 512, RTSpecialName = 1024, ReservedMask = 1024
/// </summary>

public enum EventAttributes {

    None = 0,

    SpecialName = 1,

    RtSpecialName = 2,

    ReservedMask = 3,

}
