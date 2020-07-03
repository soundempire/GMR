using System;

namespace GMR.Infrastructure
{
    public interface ILogger
    {
        void LogInfo(string message);

        void LogError(Exception exception);
    }
}
