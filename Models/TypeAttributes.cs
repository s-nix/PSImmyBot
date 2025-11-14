namespace PSImmyBot.Models;

/// <summary>
/// The string or integer value may be used. NotPublic = 0, AutoLayout = 0, AnsiClass = 0, Class = 0, Public = 1, NestedPublic = 2, NestedPrivate = 3, NestedFamily = 4, NestedAssembly = 5, NestedFamANDAssem = 6, VisibilityMask = 7, NestedFamORAssem = 7, SequentialLayout = 8, ExplicitLayout = 16, LayoutMask = 24, Interface = 32, ClassSemanticsMask = 32, Abstract = 128, Sealed = 256, SpecialName = 1024, RTSpecialName = 2048, Import = 4096, Serializable = 8192, WindowsRuntime = 16384, UnicodeClass = 65536, AutoClass = 131072, StringFormatMask = 196608, CustomFormatClass = 196608, HasSecurity = 262144, ReservedMask = 264192, BeforeFieldInit = 1048576, CustomFormatMask = 12582912
/// </summary>

public enum TypeAttributes {

    NotPublic = 0,

    AutoLayout = 1,

    AnsiClass = 2,

    Class = 3,

    Public = 4,

    NestedPublic = 5,

    NestedPrivate = 6,

    NestedFamily = 7,

    NestedAssembly = 8,

    NestedFamAndAssem = 9,

    VisibilityMask = 10,

    NestedFamOrAssem = 11,

    SequentialLayout = 12,

    ExplicitLayout = 13,

    LayoutMask = 14,

    Interface = 15,

    ClassSemanticsMask = 16,

    Abstract = 17,

    Sealed = 18,

    SpecialName = 19,

    RtSpecialName = 20,

    Import = 21,

    Serializable = 22,

    WindowsRuntime = 23,

    UnicodeClass = 24,

    AutoClass = 25,

    StringFormatMask = 26,

    CustomFormatClass = 27,

    HasSecurity = 28,

    ReservedMask = 29,

    BeforeFieldInit = 30,

    CustomFormatMask = 31,

}
