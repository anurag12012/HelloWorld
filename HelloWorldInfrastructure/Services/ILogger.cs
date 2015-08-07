//-----------------------------------------------------------------------
// <copyright file="ILogger.cs" company="Ryan Woodcox">
//  Copyright (c) 2015 All Rights Reserved
//  <author>Ryan Woodcox</author>
// </copyright>
//-----------------------------------------------------------------------

namespace HelloWorldInfrastructure.Services
{
    using System;

    /// <summary>
    /// Service for logging
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Write an INFO message to the log
        /// </summary>
        /// <param name="message">Log message</param>
        void Info(string message);

        /// <summary>
        /// Write an DEBUG message to the log
        /// </summary>
        /// <param name="message">Log message</param>
        void Debug(string message);

        /// <summary>
        /// Write an ERROR message to the log
        /// </summary>
        /// <param name="message">Log message</param>
        /// <param name="exception">Exception instance</param>
        void Error(string message, Exception exception);
    }
}
