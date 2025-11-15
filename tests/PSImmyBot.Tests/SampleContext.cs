using System.Collections.Generic;

namespace PSImmyBot.Tests;

internal sealed class SampleContext
{
    private readonly IList<string> _artifacts;

    public SampleContext(string commandName, string artifactsRoot, IList<string> artifacts)
    {
        CommandName = commandName;
        ArtifactsRoot = artifactsRoot;
        _artifacts = artifacts;
    }

    public string CommandName { get; }

    public string ArtifactsRoot { get; }

    public string CreateArtifactPath(string parameterName, string extension)
    {
        string safeName = parameterName.Replace(" ", string.Empty, StringComparison.Ordinal);
        string fileName = $"{CommandName}_{safeName}_{Guid.NewGuid():N}{extension}";
        string fullPath = Path.Combine(ArtifactsRoot, fileName);
        _artifacts.Add(fullPath);
        return fullPath;
    }
}
