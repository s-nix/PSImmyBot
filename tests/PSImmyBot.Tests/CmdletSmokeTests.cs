using System.Net.Http;
using PSImmyBot.Services;

namespace PSImmyBot.Tests;

public class CmdletSmokeTests : IClassFixture<CmdletTestFixture>
{
    private readonly CmdletTestFixture _fixture;

    public CmdletSmokeTests(CmdletTestFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public void Cmdlets_execute_without_errors_and_emit_valid_requests()
    {
        foreach (CmdletInvocationPlan plan in _fixture.Plans)
        {
            _fixture.InvokePlan(plan);
        }

        IReadOnlyCollection<ImmyBotApiService.ApiRequestContext> requests = _fixture.RecordedRequests;
        Assert.NotEmpty(requests);
        foreach (ImmyBotApiService.ApiRequestContext context in requests)
        {
            Assert.StartsWith("/", context.Endpoint, StringComparison.Ordinal);
            Assert.False(context.Endpoint.EndsWith("?", StringComparison.Ordinal), $"Endpoint '{context.Endpoint}' should not end with '?'.");
            Assert.False(context.Endpoint.EndsWith("&", StringComparison.Ordinal), $"Endpoint '{context.Endpoint}' should not end with '&'.");
            Assert.Contains(context.Method, new[] { HttpMethod.Get, HttpMethod.Post, HttpMethod.Put, HttpMethod.Patch, HttpMethod.Delete });
        }
    }
}
