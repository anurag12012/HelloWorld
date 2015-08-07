//-----------------------------------------------------------------------
// <copyright file="HelloWorldDataService.cs" company="Ryan Woodcox">
//  Copyright (c) 2015 All Rights Reserved
//  <author>Ryan Woodcox</author>
// </copyright>
//-----------------------------------------------------------------------

namespace HelloWorldInfrastructure.Services
{
    using HelloWorldInfrastructure.FrameworkWrappers;
    using HelloWorldInfrastructure.Mappers;
    using HelloWorldInfrastructure.Models;

    /// <summary>
    /// Data service for manipulating Hello World data
    /// </summary>
    public class HelloWorldDataService : IDataService
    {
        /// <summary>
        /// The application settings key for the today data file
        /// </summary>
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
        /// The Hello World Mapper
        /// </summary>
        private readonly IHelloWorldMapper helloWorldMapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="HelloWorldDataService" /> class.
        /// </summary>
        /// <param name="appSettings">The injected application settings service</param>
        /// <param name="dateTimeWrapper">The injected DateTime wrapper</param>
        /// <param name="fileIOService">The injected File IO Service</param>
        /// <param name="helloWorldMapper">The injected Hello World Mapper</param>
        public HelloWorldDataService(
            IAppSettings appSettings, 
            IDateTime dateTimeWrapper, 
            IFileIOService fileIOService,
            IHelloWorldMapper helloWorldMapper)
        {
            this.appSettings = appSettings;
            this.dateTimeWrapper = dateTimeWrapper;
            this.fileIOService = fileIOService;
            this.helloWorldMapper = helloWorldMapper;
        }

        /// <summary>
        /// Gets today's data
        /// </summary>
        /// <returns>A TodaysData model containing today's data</returns>
        public TodaysData GetTodaysData()
        {
            // Get the data
            var rawData = this.fileIOService.ReadFile(this.appSettings.Get(TodayDataFileKey)) + " as of " + this.dateTimeWrapper.Now().ToString("F");

            // Map to the return type
            var todaysData = this.helloWorldMapper.StringToTodaysData(rawData);

            return todaysData;
        }
    }
}
