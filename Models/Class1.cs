using System.Diagnostics.CodeAnalysis;

namespace Models;
public class AppSettings
{
    [NotNull]
    public string CustomParams { get; set; }
    [NotNull]
    public ConnectionStrings ConnectionStrings { get; set; }
    public string AllowedHosts { get; set; }
    public Logging Logging { get; set; }
}

public class Logging
{
    public LogLevel LogLevel { get; set; }
}
public class LogLevel
{
    public string Default { get; set; }
}
public class ConnectionStrings
{
    public string DefaultConnection { get; set; }
    public string DefaultConnection2 { get; set; }
    public string DefaultConnection3 { get; set; }
    public string DefaultConnection4 { get; set; }
}


public record AppConfig
{
    [NotNull]
    public OpenAIConfig? OpenAI { get; init; }
}

public record OpenAIConfig
{
    public string Key { get; init; } = "";
}

