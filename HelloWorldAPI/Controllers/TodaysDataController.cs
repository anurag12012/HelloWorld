//-----------------------------------------------------------------------
// <copyright file="TodaysDataController.cs">
//  Copyright (c) 2015 All Rights Reserved
//  <author>Ryan Woodcox</author>
// </copyright>
//-----------------------------------------------------------------------

namespace HelloWorldAPI.Controllers
{
    using System.Web.Http;
    using HelloWorldInfrastructure.Services;

    /// <summary>
    /// API controller for getting and setting today's value.
    /// </summary>
    public class TodaysDataController : ApiController
    {
        /// <summary>
        /// The data service
        /// </summary>
        private IDataService dataService;

        /// <summary>
        /// Creates a new instance of the controller
        /// </summary>
        /// <param name="dataService">The injected data service</param>
        public TodaysDataController(IDataService dataService)
        {
            this.dataService = dataService;
        }

        /// <summary>
        /// Gets today's value
        /// </summary>
        /// <returns>A string containing today's value</returns>
        public string Get()
        {
            return this.dataService.GetTodaysData();
        }

        /// <summary>
        /// Updates today's value with the specified value
        /// </summary>
        /// <param name="value">The upated value</param>
        public void Put(string value)
        {
        }
    }
}