namespace PSImmyBot.Models;

/// <summary>
/// The string or integer value may be used. PrivateScope = 0, ReuseSlot = 0, Private = 1, FamANDAssem = 2, Assembly = 3, Family = 4, FamORAssem = 5, Public = 6, MemberAccessMask = 7, UnmanagedExport = 8, Static = 16, Final = 32, Virtual = 64, HideBySig = 128, NewSlot = 256, VtableLayoutMask = 256, CheckAccessOnOverride = 512, Abstract = 1024, SpecialName = 2048, RTSpecialName = 4096, PinvokeImpl = 8192, HasSecurity = 16384, RequireSecObject = 32768, ReservedMask = 53248
/// </summary>

public enum MethodAttributes {

    PrivateScope = 0,

    ReuseSlot = 1,

    Private = 2,

    FamAndAssem = 3,

    Assembly = 4,

    Family = 5,

    FamOrAssem = 6,

    Public = 7,

    MemberAccessMask = 8,

    UnmanagedExport = 9,

    Static = 10,

    Final = 11,

    Virtual = 12,

    HideBySig = 13,

    NewSlot = 14,

    VtableLayoutMask = 15,

    CheckAccessOnOverride = 16,

    Abstract = 17,

    SpecialName = 18,

    RtSpecialName = 19,

    PinvokeImpl = 20,

    HasSecurity = 21,

    RequireSecObject = 22,

    ReservedMask = 23,

}
