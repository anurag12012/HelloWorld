//-----------------------------------------------------------------------
// <copyright file="TextFileDataService.cs">
//  Copyright (c) 2015 All Rights Reserved
//  <author>Ryan Woodcox</author>
// </copyright>
//-----------------------------------------------------------------------

namespace HelloWorldInfrastructure.Services
{
    /// <summary>
    /// Text file data service for maniuplating data in a text file
    /// </summary>
    public class TextFileDataService : IDataService
    {
        /// <summary>
        /// Gets today's data
        /// </summary>
        /// <returns>A string containing today's data</returns>
        public string GetTodaysData()
        {
            return "Hello World as of " + System.DateTime.Now.ToString("F");
        }

        /// <summary>
        /// Sets today's data to the specified value
        /// </summary>
        /// <param name="value">The updated value</param>
        /// <returns>A value indicating wheter the update was successful</returns>
        public bool SetTodaysData(string value)
        {
            return true;
        }
    }
}
