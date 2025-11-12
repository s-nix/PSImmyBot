// using System.Management.Automation;
// using System.Management.Automation.Runspaces;
// using PSImmyBot.Models;
// using PSImmyBot.Services;
//
// namespace PSImmyBot.Cmdlets;
//
// [Cmdlet(VerbsCommon.Get, "ApplicationLockEventEventStream")]
// public class GetApplicationLockEventEventStream : Cmdlet {
//     
//     protected override void ProcessRecord() {
//         try {
//             string endpoint = $"/api/v1/application-locks/realtime-event-stream?";
//             // ApplicationLockEventEventStream response = ImmyBotApiService.Get<ApplicationLockEventEventStream>(endpoint.TrimEnd('?').TrimEnd('&')).GetAwaiter().GetResult();
//             // WriteObject(response);
//             AzureTokenResponse token = Globals.Token
//                 ?? throw new InvalidOperationException("API token is not available.");
//             HttpClient client = new HttpClient();
//             client.BaseAddress = new Uri($"https://{Globals.GetApiConnectionConfig().ImmySubdomain}.immy.bot");
//             client.DefaultRequestHeaders.Authorization =
//                 new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.AccessToken);
//             HttpResponseMessage response = client.GetAsync(endpoint, HttpCompletionOption.ResponseHeadersRead).GetAwaiter().GetResult();
//             response.EnsureSuccessStatusCode();
//             CancellationTokenSource cts = new();
//             CancellationToken cancellationToken = cts.Token;
//             Console.WriteLine("Listening for application lock events. Press any key to stop...");
//             Task<string> readTask = Globals.ReadHttpStreamAsync(response, cts);
//             Console.ReadKey(true);
//             Console.WriteLine("Stopping...");
//             cts.Cancel();
//             Console.WriteLine("Processing received events...");
//             while (!readTask.IsCompleted) {
//                 Console.WriteLine("Waiting for read task to complete...");
//                 Thread.Sleep(1000);
//             }
//             string accumulatedData = readTask.Result;
//             string[] events = accumulatedData.Split('\n');
//             List<ApplicationLockEvent> lockEvents = [];
//             foreach (string eventData in events) {
//                 if (string.IsNullOrWhiteSpace(eventData)) {
//                     continue;
//                 }
//                 if (!eventData.StartsWith("data: ")) {
//                     continue;
//                 }
//                 string[] parts = eventData.Split(["data: "], StringSplitOptions.RemoveEmptyEntries);
//                 if (parts.Length < 1) {
//                     continue;
//                 }
//                 foreach (string part in parts) {
//                     ApplicationLockEvent? appLockEvent = System.Text.Json.JsonSerializer.Deserialize<ApplicationLockEvent>(part);
//                     if (appLockEvent != null) {
//                         lockEvents.Add(appLockEvent);
//                     }
//                 }
//             }
//             WriteObject(lockEvents, true);
//         } catch (Exception ex) {
//             WriteError(new ErrorRecord(ex, "GetApplicationLockEventEventStreamFailed", ErrorCategory.NotSpecified, null));
//         }
//     }
// }


