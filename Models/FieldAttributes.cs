namespace PSImmyBot.Models;

/// <summary>
/// The string or integer value may be used. PrivateScope = 0, Private = 1, FamANDAssem = 2, Assembly = 3, Family = 4, FamORAssem = 5, Public = 6, FieldAccessMask = 7, Static = 16, InitOnly = 32, Literal = 64, NotSerialized = 128, HasFieldRVA = 256, SpecialName = 512, RTSpecialName = 1024, HasFieldMarshal = 4096, PinvokeImpl = 8192, HasDefault = 32768, ReservedMask = 38144
/// </summary>

public enum FieldAttributes {

    PrivateScope = 0,

    Private = 1,

    FamAndAssem = 2,

    Assembly = 3,

    Family = 4,

    FamOrAssem = 5,

    Public = 6,

    FieldAccessMask = 7,

    Static = 8,

    InitOnly = 9,

    Literal = 10,

    NotSerialized = 11,

    HasFieldRva = 12,

    SpecialName = 13,

    RtSpecialName = 14,

    HasFieldMarshal = 15,

    PinvokeImpl = 16,

    HasDefault = 17,

    ReservedMask = 18,

}
