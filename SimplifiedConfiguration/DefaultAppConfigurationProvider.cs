using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace SimplifiedConfiguration
{
    /// <summary>
    /// This class is the default configuration provider which provides configurations from application 
    /// app.config/web.config files.
    /// </summary>
    internal class DefaultAppConfigurationProvider : IAppConfigurationProvider
    {
        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>the value associated with the key and null otherwise</returns>
        public string GetValue(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}
