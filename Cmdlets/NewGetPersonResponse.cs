using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetPersonResponse")]
public class NewGetPersonResponse : Cmdlet {
    [Parameter(Mandatory = false)] public ICollection<GetComputerResponse>? AdditionalComputers { get; set; }
    [Parameter(Mandatory = false)] public string? AzurePrincipalId { get; set; }
    [Parameter(Mandatory = false)] public int? CreatedBy { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset CreatedDateUtc { get; set; }
    [Parameter(Mandatory = false)] public string? DisplayName { get; set; }
    [Parameter(Mandatory = false)] public string? EmailAddress { get; set; }
    [Parameter(Mandatory = false)] public string? FirstName { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = false)] public string? LastName { get; set; }
    [Parameter(Mandatory = false)] public ICollection<GetComputerResponse>? PrimaryComputers { get; set; }
    [Parameter(Mandatory = true)] public required int TenantId { get; set; }
    [Parameter(Mandatory = false)] public int? UpdatedBy { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset UpdatedDateUtc { get; set; }
    [Parameter(Mandatory = true)] public required GetUserResponse User { get; set; }
    [Parameter(Mandatory = false)] public ICollection<GetUserAffinityResponse>? UserAffinities { get; set; }

    protected override void ProcessRecord() {
        GetPersonResponse outputObject = new(AdditionalComputers, AzurePrincipalId, CreatedBy, CreatedDateUtc, DisplayName, EmailAddress, FirstName, Id, LastName, PrimaryComputers, TenantId, UpdatedBy, UpdatedDateUtc, User, UserAffinities);
        WriteObject(outputObject);
    }
}
