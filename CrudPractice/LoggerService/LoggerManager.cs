using CrudPractice.Interfaces;
using Serilog;
using Serilog.Events;
using System.Reflection;

namespace CrudPractice.LoggerService;

public class LoggerManager : ILoggerManager
{
    static LoggerManager()
    {
        _logger = 

    }

    private static readonly Serilog.ILogger _logger; 
    private static string _logPath 
    {
        get
        {  
            var appDataDir = Environment.SpecialFolder.ApplicationData;
            var logPath = Environment.GetFolderPath(appDataDir);
            var appName = Assembly.GetExecutingAssembly().FullName;
            logPath = Path.Combine(logPath, appName!, "logs");

            return logPath;
        }
    }

    private static Serilog.ILogger ConfigureLogger()
    {
        return  new LoggerConfiguration()
        .WriteTo.Console()
        .MinimumLevel.Debug()
        .WriteTo.Conditional(e => e.Level == LogEventLevel.Fatal, conf => conf.File()) 
        .File(_logPath, rollingInterval: RollingInterval.Day, shared: true)
        .CreateLogger();
    }
        
     

    public void LogDebug(string message)
    {
        throw new NotImplementedException();
    }

    public Task LogDebugAsync(string message)
    {
        throw new NotImplementedException();
    }

    public void LogError(string message)
    {
        throw new NotImplementedException();
    }

    public Task LogErrorAsync(string message)
    {
        throw new NotImplementedException();
    }

    public void LogInfo(string message)
    {
        throw new NotImplementedException();
    }

    public Task LogInfoAsync(string message)
    {
        throw new NotImplementedException();
    }

    public void LogWarn(string message)
    {
        throw new NotImplementedException();
    }

    public Task LogWarnAsync(string message)
    {
        throw new NotImplementedException();
    }
}