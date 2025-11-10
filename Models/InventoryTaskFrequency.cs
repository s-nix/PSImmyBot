namespace PSImmyBot.Models;

/// <summary>
/// The string or integer value may be used. SpecifiedNumMinutes = 0, EveryMinute = 1, Hourly = 2, Daily = 3, Weekly = 4
/// </summary>

public enum InventoryTaskFrequency {

    SpecifiedNumMinutes = 0,

    EveryMinute = 1,

    Hourly = 2,

    Daily = 3,

    Weekly = 4,

}
