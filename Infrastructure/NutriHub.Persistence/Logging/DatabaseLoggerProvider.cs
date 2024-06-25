using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NutriHub.Domain.Entities;
using NutriHub.Persistence.EFCore.Context;

namespace NutriHub.Persistence.Logging
{
    public class DatabaseLoggerProvider : ILoggerProvider
    {
        private readonly IServiceProvider _serviceProvider;

        public DatabaseLoggerProvider(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public ILogger CreateLogger(string categoryName)
        {
            return new DatabaseLogger(_serviceProvider);
        }

        public void Dispose() { }
    }

    public class DatabaseLogger : ILogger
    {
        private readonly IServiceProvider _serviceProvider;

        public DatabaseLogger(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IDisposable BeginScope<TState>(TState state) => null;

        public bool IsEnabled(LogLevel logLevel) => logLevel >= LogLevel.Warning; // Only log warnings and above

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            if (!IsEnabled(logLevel))
            {
                return;
            }

            try
            {
                var message = formatter(state, exception);

                using (var scope = _serviceProvider.CreateScope())
                {
                    var context = scope.ServiceProvider.GetRequiredService<NutriHubContext>();
                    var logEntry = new LogEntry
                    {
                        LogLevel = logLevel.ToString(),
                        Message = message,
                        Timestamp = DateTime.UtcNow
                    };

                    context.LogEntries.Add(logEntry);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                // Log the error to a file or console for debugging purposes
                Console.WriteLine($"Failed to log to database: {ex.Message}");
            }
        }
    }

}
