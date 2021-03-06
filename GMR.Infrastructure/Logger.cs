﻿using System;
using log4net;
using log4net.Config;

namespace GMR.Infrastructure
{
    public class Logger : ILogger
    {
        private readonly ILog _log;

        public Logger()
        {
            XmlConfigurator.Configure();
            _log = LogManager.GetLogger("LOGGER");
        }

        public void LogInfo(string message) => _log.Info(message);

        public void LogError(Exception exception) => _log.Error(exception);
    }
}
