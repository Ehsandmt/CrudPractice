namespace CrudPractice.Interfaces;

public interface ILoggerManager
{
    void LogInfo(string message);
    void LogWarn(string message);
    void LogDebug(string message);
    void LogError(string message);     

    Task LogInfoAsync(string message);
    Task LogWarnAsync(string message);
    Task LogDebugAsync(string message);
    Task LogErrorAsync(string message);     
}