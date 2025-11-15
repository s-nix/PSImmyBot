using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using PSImmyBot.Cmdlets;
using PSImmyBot.Models;
using PSImmyBot.Services;

namespace PSImmyBot.Tests;

public sealed class CmdletTestFixture : IDisposable
{
    private readonly Runspace _runspace;
    private readonly string _configDirectory;
    private readonly string _artifactsDirectory;
    private readonly List<string> _artifactPaths = [];
    private readonly RecordingApiResponder _apiResponder = new();
    private readonly string _moduleName = "PSImmyBot";
    private readonly Dictionary<System.Type, string> _commandNamesByType = new();

    public CmdletTestFixture()
    {
        _configDirectory = Path.Combine(Path.GetTempPath(), $"PSImmyBot.Tests.Config_{Guid.NewGuid():N}");
        _artifactsDirectory = Path.Combine(Path.GetTempPath(), $"PSImmyBot.Tests.Artifacts_{Guid.NewGuid():N}");
        Directory.CreateDirectory(_configDirectory);
        Directory.CreateDirectory(_artifactsDirectory);

        Globals.SetConfigDirectoryOverride(_configDirectory);
        Globals.SaveApiConnectionConfig(new ApiConnectionConfig
        {
            AzureTenantDomain = "contoso.onmicrosoft.com",
            AzureClientId = Guid.NewGuid().ToString(),
            AzureClientSecret = Guid.NewGuid().ToString("N"),
            ImmySubdomain = "unit-test"
        });
        Globals.RemoveSavedApiToken();

        ImmyBotApiService.TestResponder = _apiResponder.Handle;
        ConnectApi.HttpMessageHandlerFactory = () => new StubHttpMessageHandler();

        _runspace = RunspaceFactory.CreateRunspace();
        _runspace.Open();
        ImportModule();
        LoadModuleMetadata();
        BuildCommandNameIndex();

        List<CmdletInvocationPlan> allPlans = CmdletInvocationPlanner.BuildPlans(_artifactsDirectory).ToList();
        Plans = allPlans
            .Where(plan => _commandNamesByType.ContainsKey(plan.CmdletType))
            .ToList();
    }

    internal IReadOnlyList<CmdletInvocationPlan> Plans { get; }

    internal IReadOnlyCollection<ImmyBotApiService.ApiRequestContext> RecordedRequests => _apiResponder.Requests;

    internal Runspace Runspace => _runspace;

    internal string ModuleName => _moduleName;

    internal IReadOnlyDictionary<System.Type, string> CommandNamesByType => _commandNamesByType;

    internal void InvokePlan(CmdletInvocationPlan plan)
    {
        using PowerShell powershell = PowerShell.Create();
        powershell.Runspace = _runspace;
        string resolvedCommand = ResolveCommandName(plan);
        powershell.AddCommand(resolvedCommand);
        foreach ((string key, object value) in plan.Parameters)
        {
            if (value is SwitchParameter switchParameter)
            {
                if (switchParameter.IsPresent)
                {
                    powershell.AddParameter(key);
                }
                continue;
            }
            powershell.AddParameter(key, value);
        }

        // Track artifact paths from the plan for cleanup.
        foreach (string artifact in plan.Artifacts)
        {
            _artifactPaths.Add(artifact);
        }

        try
        {
            powershell.Invoke();
        }
        catch (RuntimeException ex)
        {
            throw new InvalidOperationException($"Cmdlet {resolvedCommand} threw an exception.", ex);
        }

        if (powershell.HadErrors)
        {
            string errors = string.Join(Environment.NewLine, powershell.Streams.Error.Select(e => e.ToString()));
            throw new InvalidOperationException($"Cmdlet {resolvedCommand} failed: {errors}");
        }
    }

    private void ImportModule()
    {
        string assemblyPath = typeof(Globals).Assembly.Location;
        string moduleManifest = Path.Combine(Path.GetDirectoryName(assemblyPath) ?? throw new InvalidOperationException("Unable to locate assembly directory."), "PSImmyBot.psd1");
        using PowerShell powershell = PowerShell.Create();
        powershell.Runspace = _runspace;
        powershell.AddCommand("Import-Module")
            .AddArgument(moduleManifest)
            .AddParameter("Force", true);
        powershell.Invoke();
        if (powershell.HadErrors)
        {
            string errors = string.Join(Environment.NewLine, powershell.Streams.Error.Select(e => e.ToString()));
            throw new InvalidOperationException($"Failed to import PSImmyBot module: {errors}");
        }
    }

    private void LoadModuleMetadata()
    {
        using PowerShell powershell = PowerShell.Create();
        powershell.Runspace = _runspace;
        powershell.AddCommand("Get-Module").AddArgument(_moduleName);
        powershell.Invoke();
        if (powershell.HadErrors)
        {
            string errors = string.Join(Environment.NewLine, powershell.Streams.Error.Select(e => e.ToString()));
            throw new InvalidOperationException($"Failed to load module metadata: {errors}");
        }
    }

    private void BuildCommandNameIndex()
    {
        using PowerShell powershell = PowerShell.Create();
        powershell.Runspace = _runspace;
        powershell.AddCommand("Get-Command").AddParameter("Module", _moduleName);
        Collection<CommandInfo> commandInfos = powershell.Invoke<CommandInfo>();
        if (powershell.HadErrors)
        {
            string errors = string.Join(Environment.NewLine, powershell.Streams.Error.Select(e => e.ToString()));
            throw new InvalidOperationException($"Failed to enumerate module commands: {errors}");
        }

        foreach (CommandInfo commandInfo in commandInfos)
        {
            if (commandInfo is CmdletInfo { ImplementingType: System.Type implementingType } cmdletInfo)
            {
                string commandName = cmdletInfo.Name ?? commandInfo.Name ?? string.Empty;
                _commandNamesByType[implementingType] = commandName;
            }
        }
    }

    internal string ResolveCommandName(CmdletInvocationPlan plan) => ResolveCommandName(plan.CommandName, plan.CmdletType);

    internal string ResolveCommandName(string baseCommandName, System.Type? cmdletType = null)
    {
        if (cmdletType is { } concreteType &&
            _commandNamesByType.TryGetValue(concreteType, out string? mappedName) &&
            mappedName is not null)
        {
            return mappedName;
        }

        return baseCommandName;
    }

    public void Dispose()
    {
        try
        {
            _runspace.Dispose();
        }
        finally
        {
            ImmyBotApiService.TestResponder = null;
            ConnectApi.HttpMessageHandlerFactory = null;
            Globals.RemoveSavedApiToken();
            Globals.RemoveSavedApiConnectionConfig();
            Globals.SetConfigDirectoryOverride(null);
            TryDeleteDirectory(_configDirectory);
            TryDeleteDirectory(_artifactsDirectory);
            foreach (string artifact in _artifactPaths.Distinct())
            {
                TryDeleteFile(artifact);
            }
        }
    }

    private static void TryDeleteDirectory(string? path)
    {
        try
        {
            if (!string.IsNullOrEmpty(path) && Directory.Exists(path))
            {
                Directory.Delete(path, true);
            }
        }
        catch
        {
            // Intentionally ignored.
        }
    }

    private static void TryDeleteFile(string path)
    {
        try
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
        catch
        {
            // Intentionally ignored.
        }
    }

    private sealed class StubHttpMessageHandler : HttpMessageHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (request.RequestUri?.AbsoluteUri.Contains(".well-known/openid-configuration", StringComparison.OrdinalIgnoreCase) == true)
            {
                string metadata = JsonSerializer.Serialize(new
                {
                    token_endpoint = "https://login.microsoftonline.com/unit-test-tenant/oauth2/v2.0/token"
                });
                return Task.FromResult(CreateJsonResponse(metadata));
            }

            if (request.RequestUri?.AbsoluteUri.Contains("/oauth2/v2.0/token", StringComparison.OrdinalIgnoreCase) == true)
            {
                string tokenResponse = JsonSerializer.Serialize(new
                {
                    token_type = "Bearer",
                    expires_in = 3600,
                    ext_expires_in = 3600,
                    access_token = Convert.ToBase64String(Encoding.UTF8.GetBytes("unit-test-token"))
                });
                return Task.FromResult(CreateJsonResponse(tokenResponse));
            }

            return Task.FromResult(CreateJsonResponse("{}"));
        }

        private static HttpResponseMessage CreateJsonResponse(string payload) => new(HttpStatusCode.OK)
        {
            Content = new StringContent(payload, Encoding.UTF8, "application/json")
        };
    }
}
