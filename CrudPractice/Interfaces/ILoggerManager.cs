namespace CrudPractice.Interfaces;

public interface ILoggerManager
{
    void LogInfo(string message, object?[]? param);
    void LogWarn(string message, object?[]? param);
    void LogDebug(string message, object?[]? param);
    void LogError(string message, object?[]? param);

    //serilog have a async capability builtin
}