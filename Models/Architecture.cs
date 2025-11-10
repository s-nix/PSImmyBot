namespace PSImmyBot.Models;

/// <summary>
/// The string or integer value may be used. X86 = 0, X64 = 1, Arm = 2, Arm64 = 3, Wasm = 4, S390x = 5, LoongArch64 = 6, Armv6 = 7, Ppc64le = 8, RiscV64 = 9
/// </summary>

public enum Architecture {

    X86 = 0,

    X64 = 1,

    Arm = 2,

    Arm64 = 3,

    Wasm = 4,

    S390X = 5,

    LoongArch64 = 6,

    Armv6 = 7,

    Ppc64Le = 8,

    RiscV64 = 9,

}
