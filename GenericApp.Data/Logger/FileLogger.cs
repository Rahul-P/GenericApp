using Microsoft.Extensions.Logging;
using System;
using System.IO;

namespace GenericApp.Data.Logger
{
    public class FileLogger : ILoggerProvider
    {
        public ILogger CreateLogger(string categoryName)
        {
            return new MyLogger();
        }

        public void Dispose()
        {
        }

        private class MyLogger : ILogger
        {

            public bool IsEnabled(LogLevel logLevel)
            {
                return true;
            }

            public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception,
              Func<TState, Exception, string> formatter)
            {              
               File.AppendAllText(@"C:\temp\GenericAppEF.txt", formatter(state, exception));                            
            }

            public IDisposable BeginScope<TState>(TState state)
            {
                return null;
            }
        }
    }
}
