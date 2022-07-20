using CrudPractice.Interfaces;
using Serilog;
using Serilog.Events;
using System.Reflection;

namespace CrudPractice.LoggerService;

public class LoggerManager : ILoggerManager
{
    static LoggerManager()
    {
        _logger = ConfigureLogger();
    }

    private static readonly Serilog.ILogger _logger; 
    private static string LogPath(LogEventLevel? level = null)
    {  
            var appDataDir = Environment.SpecialFolder.ApplicationData;
            var appName = Assembly.GetExecutingAssembly().FullName;
            var logPath = Environment.GetFolderPath(appDataDir);

            logPath = Path.Combine(logPath, appName!);

            if(level is not null)
                logPath = Path.Combine(logPath, level.ToString()!);

            logPath = Path.Combine(logPath, $"log.txt");

            return logPath;
    }

    private static Serilog.ILogger ConfigureLogger() => new LoggerConfiguration()
        .MinimumLevel.Debug()
        .WriteTo.Map(e => e.Level, (level, conf) => conf.Async(con =>
            con.File(LogPath(level), rollingInterval: RollingInterval.Day, shared: true)))
            .CreateLogger();

    public void LogDebug(string message, object?[]? param = null) => _logger.Debug(message, param);

    public void LogError(string message, object?[]? param = null) => _logger.Error(message, param);

    public void LogInfo(string message, object?[]? param = null) => _logger.Information(message, param);

    public void LogWarn(string message, object?[]? param = null) => _logger.Warning(message, param);
}