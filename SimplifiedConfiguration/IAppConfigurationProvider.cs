using System;
namespace SimplifiedConfiguration
{
    /// <summary>
    /// Contract to provide application configuration
    /// </summary>
    public interface IAppConfigurationProvider
    {
        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        string GetValue(string key);
    }
}
