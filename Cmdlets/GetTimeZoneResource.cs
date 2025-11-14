using System.Management.Automation;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Cmdlets;

[Cmdlet(VerbsCommon.Get, "TimeZoneResource")]
public class GetTimeZoneResource : Cmdlet {

    protected override void ProcessRecord() {
        string endpoint = "/api/v1/system/timezones?";

        List<TimeZoneResource> response = ImmyBotApiService.Get<List<TimeZoneResource>>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
        WriteObject(response);
    }
}
