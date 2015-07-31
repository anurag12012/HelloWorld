//-----------------------------------------------------------------------
// <copyright file="LightInjectConfig.cs">
//  Copyright (c) 2015 All Rights Reserved
//  <author>Ryan Woodcox</author>
// </copyright>
//-----------------------------------------------------------------------

namespace HelloWorldAPI
{
    using System.Web.Http;
    using HelloWorldInfrastructure.Services;
    using LightInject;

    /// <summary>
    /// Configures dependency injection via LightInject
    /// </summary>
    public static class LightInjectConfig
    {
        /// <summary>
        /// Registers main components
        /// </summary>
        /// <param name="config">Http Configuration</param>
        public static void Register(HttpConfiguration config)
        {
            var container = new ServiceContainer();
            container.RegisterApiControllers();        

            container.EnablePerWebRequestScope();
            container.EnableWebApi(GlobalConfiguration.Configuration);
            container.EnableMvc();

            // Register Services
            RegisterServices(container);
        }

        /// <summary>
        /// Registers the dependency services to be injected
        /// </summary>
        /// <param name="serviceRegistry">The Service Registry</param>
        private static void RegisterServices(IServiceRegistry serviceRegistry)
        {
            // Register default Data Service
            serviceRegistry.Register<IDataService, TextFileDataService>();
        }
    }
}
