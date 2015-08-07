//-----------------------------------------------------------------------
// <copyright file="TextFileIOService.cs">
//  Copyright (c) 2015 All Rights Reserved
//  <author>Ryan Woodcox</author>
// </copyright>
//-----------------------------------------------------------------------

namespace HelloWorldInfrastructure.Services
{
    using System.IO;

    /// <summary>
    /// Service for text file IO
    /// </summary>
    public class TextFileIOService : IFileIOService
    {
        /// <summary>
        /// The hosting environment service
        /// </summary>
        private readonly IHostingEnvironmentService hostingEnvironmentService;

        /// <summary>
        /// Creates a new instance of TextFileIOService
        /// </summary>
        /// <param name="hostingEnvironmentService">The injected hosting environment service</param>
        public TextFileIOService(IHostingEnvironmentService hostingEnvironmentService)
        {
            this.hostingEnvironmentService = hostingEnvironmentService;
        }

        /// <summary>
        /// Reads the specified file
        /// </summary>
        /// <param name="filePath">File path</param>
        /// <returns>The contents of the file</returns>
        public string ReadFile(string filePath)
        {
            string fileContents;

            // Map path to server path
            var serverPath = this.hostingEnvironmentService.MapPath(filePath);

            // read the contents of the file
            using (var reader = new StreamReader(serverPath))
            {
                fileContents = reader.ReadToEnd();
            }

            return fileContents;
        }
    }
}
