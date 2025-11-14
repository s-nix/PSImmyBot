namespace PSImmyBot.Models;

/// <summary>
/// The string or integer value may be used. Obo = 1, DefaultAppRegistration = 2, CustomAppRegistration = 3, OboPartnerCenter = 4
/// </summary>

public enum AccessTokenSource {
    Obo = 0,
    DefaultAppRegistration = 1,
    CustomAppRegistration = 2,
    OboPartnerCenter = 3,
}
