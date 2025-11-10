namespace PSImmyBot.Models;

/// <summary>
/// The string or integer value may be used. Constructor = 1, Event = 2, Field = 4, Method = 8, Property = 16, TypeInfo = 32, Custom = 64, NestedType = 128, All = 191
/// </summary>

public enum MemberTypes {

    Constructor = 0,

    Event = 1,

    Field = 2,

    Method = 3,

    Property = 4,

    TypeInfo = 5,

    Custom = 6,

    NestedType = 7,

    All = 8,

}
