using System.Management.Automation;
using PSImmyBot.Models;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.New, "GetUserAffinityResponse")]
public class NewGetUserAffinityResponse : Cmdlet {
    [Parameter(Mandatory = true)] public required int ComputerId { get; set; }
    [Parameter(Mandatory = true)] public required DateTimeOffset Date { get; set; }
    [Parameter(Mandatory = true)] public required int Id { get; set; }
    [Parameter(Mandatory = true)] public required GetPersonResponse Person { get; set; }
    [Parameter(Mandatory = true)] public required int PersonId { get; set; }

    protected override void ProcessRecord() {
        GetUserAffinityResponse outputObject = new(ComputerId, Date, Id, Person, PersonId);
        WriteObject(outputObject);
    }
}
