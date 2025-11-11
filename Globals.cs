using System.Text.Json;
using PSImmyBot.Models;
using PropertyInfo = System.Reflection.PropertyInfo;

namespace PSImmyBot;
internal static class Globals {
    private static JsonSerializerOptions JsonSerializerOptions { get; } =
        new JsonSerializerOptions {
            WriteIndented = true
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
    public static string ConvertToQueryParameters<T>(T objectToConvert) {
        if (objectToConvert == null) {
            return string.Empty;
        }

        PropertyInfo[] properties = typeof(T).GetProperties();
        List<string> queryParameters = [];

        foreach (PropertyInfo property in properties) {
            object? value = property.GetValue(objectToConvert);
            if (value == null) {
                continue;
            }
            string stringValue = Uri.EscapeDataString(value.ToString() ?? string.Empty);
            queryParameters.Add($"{property.Name}={stringValue}");
        }

        return string.Join("&", queryParameters) + "&";
    }
}
