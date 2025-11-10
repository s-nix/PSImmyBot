namespace PSImmyBot.Models;

/// <summary>
/// The string or integer value may be used. None = 0, In = 1, Out = 2, Lcid = 4, Retval = 8, Optional = 16, HasDefault = 4096, HasFieldMarshal = 8192, Reserved3 = 16384, Reserved4 = 32768, ReservedMask = 61440
/// </summary>

public enum ParameterAttributes {

    None = 0,

    In = 1,

    Out = 2,

    Lcid = 3,

    Retval = 4,

    Optional = 5,

    HasDefault = 6,

    HasFieldMarshal = 7,

    Reserved3 = 8,

    Reserved4 = 9,

    ReservedMask = 10,

}
