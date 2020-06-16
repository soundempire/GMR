using System;

namespace GMR.Logging
{
    public interface ILogger
    {
        void LogInfo(string message);

        void LogError(Exception exception);
    }
}
