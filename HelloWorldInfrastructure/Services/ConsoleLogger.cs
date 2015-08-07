//-----------------------------------------------------------------------
// <copyright file="ConsoleLogger.cs" company="Ryan Woodcox">
//  Copyright (c) 2015 All Rights Reserved
//  <author>Ryan Woodcox</author>
// </copyright>
//-----------------------------------------------------------------------

namespace HelloWorldInfrastructure.Services
{
    using System;
    using HelloWorldInfrastructure.FrameworkWrappers;

    /// <summary>
    /// Service for logging to the Console window
    /// </summary>
    public class ConsoleLogger : ILogger
    {
        /// <summary>
        /// The Console abstraction for writing to the console.
        /// </summary>
        private readonly IConsole console;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConsoleLogger" /> class.
        /// </summary>
        /// <param name="console">The injected console</param>
        public ConsoleLogger(IConsole console)
        {
            this.console = console;
        }

        /// <summary>
        /// Write an INFO message to the log
        /// </summary>
        /// <param name="message">Log message</param>
        public void Info(string message)
        {
            this.console.WriteLine("INFO: " + message);
        }

        /// <summary>
        /// Write an DEBUG message to the log
        /// </summary>
        /// <param name="message">Log message</param>
        public void Debug(string message)
        {
            this.console.WriteLine("DEBUG: " + message);
        }

        /// <summary>
        /// Write an ERROR message to the log
        /// </summary>
        /// <param name="message">Log message</param>
        /// <param name="exception">Exception instance</param>
        public void Error(string message, Exception exception)
        {
            var logMessage = "ERROR: " + message;

            // Check for an exception
            if (exception != null)
            {
                logMessage += "[Exception:" + exception.ToString() + " ]";
            }

            this.console.WriteLine(logMessage);
        }
    }
}
