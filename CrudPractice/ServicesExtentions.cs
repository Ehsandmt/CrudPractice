using CrudPractice.LoggerService;
using CrudPractice.Interfaces;

namespace CrudPractice;

public static class ServiceExtensions
{
    public static IServiceCollection ConfigureLoggerManager(this IServiceCollection services)
         => services.AddSingleton<ILoggerManager, LoggerManager>();

}