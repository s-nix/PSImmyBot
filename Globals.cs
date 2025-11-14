using System.Text.Json;
using PSImmyBot.Models;
using System.Globalization;
using System.Text;

namespace PSImmyBot;

internal static class Globals {
    private static JsonSerializerOptions JsonSerializerOptions { get; } =
        new JsonSerializerOptions {
            WriteIndented = true
        };
    private static JsonSerializerOptions LoadJsonSerializerOptions { get; } =
        new JsonSerializerOptions {
            WriteIndented = false
        };
    private static string ConfigDirectoryPath =>
        Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "PSImmyBot"
        );

    private static string ApiConnectionConfigFilePath =>
        Path.Combine(ConfigDirectoryPath, "api_connection_config.json");

    private static string ApiTokenPath =>
        Path.Combine(ConfigDirectoryPath, "api_token.json");

    public static AzureTokenResponse? Token => GetSavedApiToken();

    public static void SaveApiToken(AzureTokenResponse token) {
        if (!Directory.Exists(ConfigDirectoryPath)) {
            _ = Directory.CreateDirectory(ConfigDirectoryPath);
        }
        string json = JsonSerializer.Serialize(token, JsonSerializerOptions);
        File.WriteAllText(ApiTokenPath, json);
    }

    public static void RemoveSavedApiToken() {
        if (File.Exists(ApiTokenPath)) {
            File.Delete(ApiTokenPath);
        }
    }

    private static AzureTokenResponse? GetSavedApiToken() {
        if (!File.Exists(ApiTokenPath)) {
            return null;
        }
        string json = File.ReadAllText(ApiTokenPath);
        AzureTokenResponse token = JsonSerializer.Deserialize<AzureTokenResponse>(json)
            ?? throw new JsonException($"Failed to deserialize API token. File: {ApiTokenPath}");
        return token.ExpirationTime > DateTime.UtcNow.AddMinutes(5) ? token : null;
    }

    public static ApiConnectionConfig GetApiConnectionConfig() {
        _ = new ApiConnectionConfig();
        ApiConnectionConfig? config;
        if (File.Exists(ApiConnectionConfigFilePath)) {
            string json = File.ReadAllText(ApiConnectionConfigFilePath);
            config = JsonSerializer.Deserialize<ApiConnectionConfig>(json)
                ?? throw new JsonException($"Failed to deserialize API connection configuration. File: {ApiConnectionConfigFilePath}");
        } else {
            throw new FileNotFoundException($"API connection configuration file not found. File: {ApiConnectionConfigFilePath}");
        }
        return config;
    }

    public static ApiConnectionConfig SaveApiConnectionConfig(ApiConnectionConfig config) {
        if (!Directory.Exists(ConfigDirectoryPath)) {
            _ = Directory.CreateDirectory(ConfigDirectoryPath);
        }
        string json = JsonSerializer.Serialize(config, JsonSerializerOptions);
        File.WriteAllText(ApiConnectionConfigFilePath, json);
        return config;
    }

    public static void RemoveSavedApiConnectionConfig() {
        if (File.Exists(ApiConnectionConfigFilePath)) {
            File.Delete(ApiConnectionConfigFilePath);
        }
    }
    public static string ConvertToQueryParameters(DataSourceLoadOptions? loadOptions) {
        if (loadOptions == null) {
            return string.Empty;
        }

        StringBuilder sb = new();
        Append(nameof(DataSourceLoadOptions.AllowAsyncOverSync), loadOptions.AllowAsyncOverSync);
        Append(nameof(DataSourceLoadOptions.DefaultSort), loadOptions.DefaultSort);
        Append(nameof(DataSourceLoadOptions.ExpandLinqSumType), loadOptions.ExpandLinqSumType);
        Append(nameof(DataSourceLoadOptions.Filter), loadOptions.Filter);
        Append(nameof(DataSourceLoadOptions.Group), loadOptions.Group);
        Append(nameof(DataSourceLoadOptions.GroupSummary), loadOptions.GroupSummary);
        Append(nameof(DataSourceLoadOptions.IsCountQuery), loadOptions.IsCountQuery);
        Append(nameof(DataSourceLoadOptions.IsSummaryQuery), loadOptions.IsSummaryQuery);
        Append(nameof(DataSourceLoadOptions.PaginateViaPrimaryKey), loadOptions.PaginateViaPrimaryKey);
        Append(nameof(DataSourceLoadOptions.PreSelect), loadOptions.PreSelect);
        Append(nameof(DataSourceLoadOptions.PrimaryKey), loadOptions.PrimaryKey);
        Append(nameof(DataSourceLoadOptions.RemoteGrouping), loadOptions.RemoteGrouping);
        Append(nameof(DataSourceLoadOptions.RemoteSelect), loadOptions.RemoteSelect);
        Append(nameof(DataSourceLoadOptions.RequireGroupCount), loadOptions.RequireGroupCount);
        Append(nameof(DataSourceLoadOptions.RequireTotalCount), loadOptions.RequireTotalCount);
        Append(nameof(DataSourceLoadOptions.Select), loadOptions.Select);
        Append(nameof(DataSourceLoadOptions.Skip), loadOptions.Skip);
        Append(nameof(DataSourceLoadOptions.Sort), loadOptions.Sort);
        Append(nameof(DataSourceLoadOptions.SortByPrimaryKey), loadOptions.SortByPrimaryKey);
        Append(nameof(DataSourceLoadOptions.StringToLower), loadOptions.StringToLower);
        Append(nameof(DataSourceLoadOptions.Take), loadOptions.Take);
        Append(nameof(DataSourceLoadOptions.TotalSummary), loadOptions.TotalSummary);

        return sb.ToString();

        void Append(string name, object? val) {
            if (val == null) return;

            string str = val switch {
                string s => s,
                bool b => b ? "true" : "false",
                sbyte or byte or short or ushort or int or uint or long or ulong or float or double or decimal => Convert.ToString(val, CultureInfo.InvariantCulture) ?? string.Empty,
                _ => JsonSerializer.Serialize(val, LoadJsonSerializerOptions)
            };
            name = name[..1].ToLowerInvariant() + name[1..];
            sb.Append(name).Append('=').Append(Escape(str)).Append('&');
        }

        string Escape(string s) => Uri.EscapeDataString(s);
    }
    
    public static string ConvertToQueryParameters<T>(T? value, string paramName) {
        if (value == null) {
            return string.Empty;
        }
        string stringValue = Uri.EscapeDataString(value.ToString() ?? string.Empty);
        return $"{paramName}={stringValue}&";
    }
}
