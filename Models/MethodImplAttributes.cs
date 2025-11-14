namespace PSImmyBot.Models;

/// <summary>
/// The string or integer value may be used. IL = 0, Managed = 0, Native = 1, OPTIL = 2, CodeTypeMask = 3, Runtime = 3, ManagedMask = 4, Unmanaged = 4, NoInlining = 8, ForwardRef = 16, Synchronized = 32, NoOptimization = 64, PreserveSig = 128, AggressiveInlining = 256, AggressiveOptimization = 512, InternalCall = 4096, MaxMethodImplVal = 65535
/// </summary>

public enum MethodImplAttributes {

    Il = 0,

    Managed = 1,

    Native = 2,

    Optil = 3,

    CodeTypeMask = 4,

    Runtime = 5,

    ManagedMask = 6,

    Unmanaged = 7,

    NoInlining = 8,

    ForwardRef = 9,

    Synchronized = 10,

    NoOptimization = 11,

    PreserveSig = 12,

    AggressiveInlining = 13,

    AggressiveOptimization = 14,

    InternalCall = 15,

    MaxMethodImplVal = 16,

}
