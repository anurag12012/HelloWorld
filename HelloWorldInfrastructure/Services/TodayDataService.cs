//-----------------------------------------------------------------------
// <copyright file="TodayDataService.cs">
//  Copyright (c) 2015 All Rights Reserved
//  <author>Ryan Woodcox</author>
// </copyright>
//-----------------------------------------------------------------------

namespace HelloWorldInfrastructure.Services
{
    using HelloWorldInfrastructure.FrameworkWrappers;

    /// <summary>
    /// Text file data service for maniuplating data in a text file
    /// </summary>
    public class TodayDataService : IDataService
    {
        private const string TodayDataFileKey = "TodaysDataFile";

        /// <summary>
        /// The application settings service
        /// </summary>
        private readonly IAppSettings appSettings;

        /// <summary>
        /// The DateTime wrapper
        /// </summary>
        private readonly IDateTime dateTimeWrapper;

        /// <summary>
        /// The File IO service
        /// </summary>
        private readonly IFileIOService fileIOService;

        /// <summary>
        /// Creates a new instance of TextFileDataService
        /// </summary>
        /// <param name="appSettings">The injected application settings service</param>
        /// <param name="dateTimeWrapper">The injected DateTime wrapper</param>
        /// <param name="fileIOService">The injected File IO Service</param>
        public TodayDataService(IAppSettings appSettings, IDateTime dateTimeWrapper, IFileIOService fileIOService)
        {
            this.appSettings = appSettings;
            this.dateTimeWrapper = dateTimeWrapper;
            this.fileIOService = fileIOService;
        }

        /// <summary>
        /// Gets today's data
        /// </summary>
        /// <returns>A string containing today's data</returns>
        public string GetTodaysData()
        {
            return this.fileIOService.ReadFile(this.appSettings.Get(TodayDataFileKey)) + " as of " + this.dateTimeWrapper.Now().ToString("F");
        }
    }
}
