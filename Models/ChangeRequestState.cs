namespace PSImmyBot.Models;

/// <summary>
/// The string or integer value may be used. WaitingForApproval = 1, Denied = 2, ApprovedAndApplied = 3, NeedsAttention = 4
/// </summary>

public enum ChangeRequestState {

    WaitingForApproval = 0,

    Denied = 1,

    ApprovedAndApplied = 2,

    NeedsAttention = 3,

}
