namespace PSImmyBot.Models;

[System.CodeDom.Compiler.GeneratedCode("NSwag", "14.6.1.0 (NJsonSchema v11.5.1.0 (Newtonsoft.Json v13.0.0.0))")]
public class FileParameter(Stream data, string? fileName, string? contentType) {
    public FileParameter(Stream data)
        : this(data, null, null) {
    }

    public FileParameter(Stream data, string? fileName)
        : this(data, fileName, null) {
    }

    public Stream Data { get; private set; } = data;

    public string? FileName { get; private set; } = fileName;

    public string? ContentType { get; private set; } = contentType;
}
