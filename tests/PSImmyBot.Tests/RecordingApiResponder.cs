using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using PSImmyBot.Services;

namespace PSImmyBot.Tests;

internal sealed class RecordingApiResponder
{
    private readonly ConcurrentBag<ImmyBotApiService.ApiRequestContext> _requests = new();

    public object? Handle(ImmyBotApiService.ApiRequestContext context)
    {
        _requests.Add(context);
        return null;
    }

    public IReadOnlyCollection<ImmyBotApiService.ApiRequestContext> Requests => _requests.ToList();
}
